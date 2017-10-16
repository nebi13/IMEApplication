﻿using LoginForm.DataSet;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace LoginForm.Services
{
    class AuthorizationService
    {
        public static List<RoleValue> getRoles()
        {
            return new IMEEntities().RoleValues.ToList();
        }
        public static List<AuthorizationValue> getAuths()
        {
            return new IMEEntities().AuthorizationValues.ToList();
        }

        public static List<Worker> getWorkers()
        {
            IMEEntities ime = new IMEEntities();
            return ime.Workers.ToList();
        }
        
        public static bool AddAuthToRole(AuthorizationValue Auth)
        {
            try
            {
                IMEEntities IME = new IMEEntities();
                IME.AuthorizationValues.Add(Auth);
                IME.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public static bool AddRole(RoleValue role)
        {
            try
            {
                IMEEntities IME = new IMEEntities();
                IME.RoleValues.Add(role);
                IME.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }

        }





        //public List<AuthorizationValue> GetAvailAuthorization(Worker Worker)
        //{


        //    return IME.AuthorizationValues.Where(a => !a.Workers.Any(w => w.WorkerID == Worker.WorkerID)).ToList();

        //}
        //public List<AuthorizationValue> GetUserAuthorization(Worker Worker)
        //{

        //    return IME.AuthorizationValues.Where(a => a.Workers.Any(w => w.WorkerID == Worker.WorkerID)).ToList();

        //}
        public List<AuthorizationValue> Authorizations()
        {
            return new IMEEntities().AuthorizationValues.ToList();
        }
        public void AddNewAuthorization(AuthorizationValue NewAuthorization)
        {
            IMEEntities IME = new IMEEntities();
            IME.AuthorizationValues.Add(NewAuthorization);
            IME.SaveChanges();
        }
        public void Add(int AutID, int WorkerID)
        {
            using (SqlConnection connection = new SqlConnection("data source=.;initial catalog=IME;integrated security=True;multipleactiveresultsets=True"))
            {
                String query = "INSERT INTO dbo.UserAuthorization (WorkerID,AuthorizationID) VALUES (@WorkerID,@AutID)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AutID", AutID);
                    command.Parameters.AddWithValue("@WorkerID", WorkerID);

                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    connection.Close();
                    // Check Error

                }
            }
        }
        public void Delete(int AutID, int WorkerID)
        {
            using (SqlConnection connection = new SqlConnection("data source=.;initial catalog=IME;integrated security=True;multipleactiveresultsets=True"))
            {
                String query = "DELETE FROM dbo.UserAuthorization WHERE WorkerID = @worker AND AuthorizationID = @authorization";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@authorization", AutID);
                    command.Parameters.AddWithValue("@worker", WorkerID);

                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    connection.Close();
                    // Check Error

                }
            }
        }
    }
}
