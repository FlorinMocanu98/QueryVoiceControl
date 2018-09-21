using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QueryVoiceControl.Models;
using QueryVoiceControl.Data;
using QueryVoiceControl.ViewModel;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Data.SqlClient;
using System.Reflection;



namespace QueryVoiceControl.Controllers {
    public class HomeController : Controller {



        private readonly MyDbContext _context;


        public HomeController(MyDbContext context) {
            _context = context;
        }


        [HttpGet]
        public IActionResult Index() {
            return View(new IndexViewModel());
        }

        [HttpPost]

        public IActionResult Index(IndexViewModel model) {

            if (model.Speech != null) {

                string connectionString = "Server=(localdb)\\mssqllocaldb;Database=QueryVoiceControl;Trusted_Connection=True;MultipleActiveResultSets=true";

                /* Prende la stringa con il messaggio vocale, la trasforma in maiuscolo, poi a tutte le parole applica il capitalize
                   ed infine avviene la divisione delle parole che saranno memorizzate in un array */
                string txt = model.Speech.ToUpper();
                txt = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(txt.ToLower());
                string[] parole = txt.Split(' ');


                // Riempie tableNames con i nomi delle tabelle del database
                FieldInfo[] mytables = _context.GetType().GetFields(BindingFlags.Public |
                                              BindingFlags.NonPublic |
                                              BindingFlags.Instance);
                List<string> tableNames = new List<string>();
                foreach (var item in mytables) {
                    tableNames.Add(item.Name.Split('<', '>')[1]);
                }

                if (parole.Count() == 1) {

                    if (tableNames.Contains(parole[0])) {

                        string queryString = String.Format("SELECT * FROM dbo.{0}", parole[0]);
                        int rowcount = 0;

                        try {

                            using (SqlConnection connection = new SqlConnection(connectionString)) {
                                connection.Open();
                                SqlCommand command = new SqlCommand(queryString, connection);
                                var countreader = command.ExecuteReader();
                        
                                if (countreader.HasRows) {
                                    while (countreader.Read()) {
                                        rowcount++;
                                    }
                                }

                                countreader.Close();
                                SqlDataReader reader = command.ExecuteReader();
                                string[,] myval = new string[rowcount, reader.FieldCount];

                                try {

                                    int i = 0;

                                    if (reader.HasRows) {

                                        while (reader.Read()) {

                                            for (int j = 0; j < myval.GetLength(1); j++)
                                                myval[i, j] = reader.GetValue(j).ToString();

                                            i++;
                                        }
                                    }
                                } finally {
                                    reader.Close();
                                }
                                return View(new IndexViewModel() { Tabella = myval });
                            }
                        } catch {

                        } finally {

                        }
                    } else {

                        List<string> listaval = new List<string>();
                        for (int z = 0; z < tableNames.Count; z++) {

                            try {

                                List<string> columns = new List<string>();
                                string queryString = String.Format("SELECT * FROM dbo.{0}", tableNames.ElementAt(z));


                                using (SqlConnection connection = new SqlConnection(connectionString)) {
                                    SqlCommand command = new SqlCommand(queryString, connection);

                                    connection.Open();
                                    SqlDataReader reader = command.ExecuteReader();

                                    if (reader.HasRows) {

                                        reader.Read();
                                        for (int p = 0; p < reader.FieldCount; p++) {




                                            columns.Add(reader.GetName(p));
                                            if (columns.ElementAt(p) == parole[0]) {
                                                reader.Close();
                                                int rowcount = 0;

                                                string queryString3 = String.Format("SELECT {0} FROM dbo.{1}", columns.ElementAt(p), tableNames.ElementAt(z));
                                                SqlCommand command3 = new SqlCommand(queryString3, connection);
                                                SqlDataReader countreader = command3.ExecuteReader();

                                                if (countreader.HasRows) {
                                                    while (countreader.Read()) {
                                                        rowcount++;
                                                    }
                                                }
                                                countreader.Close();


                                                string queryString2 = String.Format("SELECT {0} FROM dbo.{1}", columns.ElementAt(p), tableNames.ElementAt(z));
                                                SqlCommand command2 = new SqlCommand(queryString2, connection);


                                                SqlDataReader reader2 = command2.ExecuteReader();
                                                string[,] myval = new string[rowcount, reader2.FieldCount];
                                                int i = 0;
                                                if (reader2.HasRows) {
                                                    while (reader2.Read()) {
                                                        for (int j = 0; j < myval.GetLength(1); j++)
                                                            myval[i, j] = reader2.GetValue(j).ToString();
                                                        i++;
                                                    }
                                                    for (int j = 0; j < myval.GetLength(0); j++) {
                                                        listaval.Add(myval[j, 0]);
                                                    }
                                                }
                                                reader2.Close();
                                                reader = command.ExecuteReader();

                                            }
                                        }
                                    }

                                    reader.Close();

                                }
                            } catch {

                            } finally {

                            }

                        }
                        string[,] myval2 = new string[listaval.Count, 1];
                        for (int j = 0; j < listaval.Count; j++)
                            myval2[j, 0] = listaval.ElementAt(j);


                        //var stud = _context.Set<Studente>().ToList();
                        return View(new IndexViewModel { Tabella = myval2 });
                        //string queryStringa = String.Format("SELECT * FROM dbo.{0}", tableNames.ElementAt(z));

                    }
                }


            }

            
            return View(new IndexViewModel());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
