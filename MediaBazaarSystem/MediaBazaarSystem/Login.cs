﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace MediaBazaarSystem
{
    public partial class formLogin : Form
    {
        /**
         * Constructor
         */
        public formLogin()
        {
            InitializeComponent();
            txtBoxPassword.PasswordChar = Convert.ToChar("*");
        }

        /**
         * Method to login based on valid credentials
         */
        private void btnLogin_Click( object sender, EventArgs e )
        {
            String email = txtBoxEmail.Text;
            String password = txtBoxPassword.Text;
            String toDecryptPassword = "";
            String depName;
            int depID;
            int role;

            using( MySqlConnection connection = new MySqlConnection( @"Server = studmysql01.fhict.local; Uid = dbi437493; Database = dbi437493; Pwd = dbgroup01;" ) )
            {
                // SQL query to get the user based on login credentials
                MySqlCommand cmd = new MySqlCommand("SELECT person.Id, person.Firstname, person.Lastname, person.Age, person.Address, person.Email, person.Password, person.Salary, " +
                    "person.HoursWorked, person.HoursAvailable, person.IsAvailable, person.RoleID, department.Name, person.DepartmentID FROM person JOIN department ON Person.DepartmentID = Department.id " +
                    "WHERE email = @email", connection ); 
                cmd.Parameters.Add("email", MySqlDbType.VarChar).Value = email;

                // Open connection
                connection.Open();

                MySqlDataReader reader = cmd.ExecuteReader( CommandBehavior.CloseConnection );

                try
                {
                    // If the data is available then log user in and open navigation form
                    // else show error message
                    if( reader.Read() )
                    {
                        // The number is based on the column... 
                        //E.g. password is column 6 and email is column 5
                        toDecryptPassword = reader.GetString( 6 ) ;
                        role = (int)reader.GetValue( 11 );

                        //Department
                        depName = reader.GetString( 12 );
                        depID = (int)reader.GetValue(13);
                        Department department = new Department( depName, depID );      
                        
                        // Decrypt password and check if password is equal to the password user filled in
                        if( Cryptography.Decrypt( toDecryptPassword ) == password )
                        {
                            if(role == 1) // Manager
                            {
                                int ID = (int)reader.GetValue(0);
                                String firstName = reader.GetString(1);
                                String lastName = reader.GetString(2);
                                int age = (int)reader.GetValue(3);
                                String address = reader.GetString(4);
                                String charge = "Manager";
                                double salary = reader.GetDouble(7);
                                int hoursavailable = (int)reader.GetValue(9);
                                Manager manager = new Manager(ID, firstName, lastName, age, address, charge, salary, hoursavailable, email);
                                AdministrationSystem administrationSystem = new AdministrationSystem( department, manager );

                                administrationSystem.Show();
                                this.Hide();
                            }
                            else if(role == 2) // Employee
                            {
                                String employeeID = reader.GetValue( 0 ).ToString();
                                String employeeName = reader.GetValue(1).ToString();
                                String employeeLastName = reader.GetValue(2).ToString();
                                String employeeAge = reader.GetValue(3).ToString();
                                String employeeAddress = reader.GetValue(4).ToString(); 
                                String employeeEmail = reader.GetValue(5).ToString();
                                EmployeeSystem employeeSystem = new EmployeeSystem( employeeID, employeeName, employeeLastName, employeeAge, employeeAddress, employeeEmail );

                                employeeSystem.Show();
                                this.Hide();
                            }
                        }
                        else if( (Cryptography.Decrypt( toDecryptPassword ) != password) || (password == null) )
                        {
                            MessageBox.Show( "Email or password is incorrect. Please try again." );
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email or password is incorrect. Please try again.");
                    }
                }
                catch( FormatException ex )
                {
                    MessageBox.Show( ex.ToString() );
                }
                connection.Close();
            }
        }

        /**
         * Method to register a user to the system
         */
        private void btnRegister_Click( object sender, EventArgs e )
        {
            // Set variables
            String email = txtBoxEmail.Text;
            String password = Cryptography.Encrypt( txtBoxPassword.Text );
                
            using( MySqlConnection connection = new MySqlConnection( @"Server = studmysql01.fhict.local; Uid = dbi437493; Database = dbi437493; Pwd = dbgroup01;" ) )
            {
                // SQL query
                String query = "INSERT INTO Person (email, password) VALUES (@email, @password)";

                try
                {
                    // Open connection
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand( query, connection );
                    // Use parameterised variables to prevent SQL-injection
                    cmd.Parameters.AddWithValue( "@email", email );
                    cmd.Parameters.AddWithValue( "@password", password );
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
                catch( Exception es )
                {
                    MessageBox.Show( es.Message );
                }
            }
        }
    }
}
