﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServerFTM.Models;
using ServerFTM.DAL.Query;
using ServerFTM.DAL.DataProvider;
using System.Data;
using System.Reflection;

namespace ServerFTM.DAL.Controls
{
    class DAL_Controls
    {
        private static DAL_Controls controls;
        public static DAL_Controls Controls
        {
            get
            {
                if (controls == null)
                    controls = new DAL_Controls();
                return controls;
            }
            set => controls = value;
        }
        public bool SignUp(Account account)
        {
            try
            {
                return DataProvider.DataProvider.Instance.ExecuteNonQuery(DefineSQLQuery.ProcSignUp, 
                    new object[] { 
                        account.IDAccount, 
                        account.Username , 
                        account.Password, 
                        account.Name, 
                        account.Acctype })>0; //--@id   @user @pass @name @acctype
            }
            catch
            {
                return false;
            }
        }

        public DataTable Login(Account account)
        {
            try
            {
                return DataProvider.DataProvider.Instance.ExecuteQuery(DefineSQLQuery.ProcLogin, 
                    new object[] {
                        account.Username,
                        account.Password }); //--@id   @user @pass @name @acctype
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public DataTable GetAllFlight()
        {
            try
            {
                return DataProvider.DataProvider.Instance.ExecuteQuery(DefineSQLQuery.ProcGetAllFlight);
                    
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public List<T> CreateListFromTable<T>(DataTable dt)
        {
            var columnNames = dt.Columns.Cast<DataColumn>().Select(c => c.ColumnName.ToLower()).ToList();
            var properties = typeof(T).GetProperties();
            return dt.AsEnumerable().Select(row => {
                var objT = Activator.CreateInstance<T>();
                foreach (var pro in properties)
                {
                    if (columnNames.Contains(pro.Name.ToLower()))
                    {
                        try
                        {
                            pro.SetValue(objT, row[pro.Name]);
                        }
                        catch (Exception ex) { }
                    }
                }
                return objT;
            }).ToList();
        }

      
    }
}
