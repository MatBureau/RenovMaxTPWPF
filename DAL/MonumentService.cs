using RenovMaxTP.Modele;
using RenovMaxTP.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls.Primitives;

namespace RenovMaxTP.DAL
{
    public class MonumentService
    {
        public static ObservableCollection<Monument> SelectMonument()
        {
            ObservableCollection<Monument> lst_Monuments = new ObservableCollection<Monument>();
            SqlCommand cmd = new SqlCommand("SELECT idMonument, nom, budget FROM Monument", DBConnector.Connection);
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int idMonument = (int)reader["idMonument"];
                    string nomMonument = (string)reader["nom"];
                    int budgetMonument = (int)reader["budget"];
                    
                    var Monument = new Monument();
                    Monument.ID = idMonument;
                    Monument.Nom = nomMonument;
                    Monument.Budget = budgetMonument;
                    
                    lst_Monuments.Add(Monument);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return lst_Monuments;
        }

        public static Monument AddNewMonument(Monument monToAdd)
        {
            try
            {
                SqlCommand cmd = new SqlCommand($"INSERT INTO Monument(nom, budget) VALUES('{monToAdd.Nom}',{monToAdd.Budget})", DBConnector.Connection);
                cmd.ExecuteScalar();
                monToAdd = SelectMonumentByNomAndBudget(monToAdd.Budget,monToAdd.Nom);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur lors de l'ajout en base d'un monument");
            }
            return monToAdd;
        }

        public static Monument SelectMonumentByID(int id)
        {
            ObservableCollection<Monument> lst_Monuments = new ObservableCollection<Monument>();
            SqlCommand cmd = new SqlCommand($"SELECT idMonument, nom, budget FROM Monument WHERE idMonument={id}", DBConnector.Connection);
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int idMonument = (int)reader["idMonument"];
                    string nomMonument = (string)reader["nom"];
                    int budgetMonument = (int)reader["budget"];

                    var Monument = new Monument();
                    Monument.ID = idMonument;
                    Monument.Nom = nomMonument;
                    Monument.Budget = budgetMonument;

                    lst_Monuments.Add(Monument);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return lst_Monuments.First();
        }

        public static Monument SelectMonumentByNomAndBudget(int budget,string nom)
        {
            ObservableCollection<Monument> lst_Monuments = new ObservableCollection<Monument>();
            SqlCommand cmd = new SqlCommand($"SELECT idMonument, nom, budget FROM Monument WHERE budget={budget} AND nom='{nom}'", DBConnector.Connection);
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int idMonument = (int)reader["idMonument"];
                    string nomMonument = (string)reader["nom"];
                    int budgetMonument = (int)reader["budget"];

                    var Monument = new Monument();
                    Monument.ID = idMonument;
                    Monument.Nom = nomMonument;
                    Monument.Budget = budgetMonument;

                    lst_Monuments.Add(Monument);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return lst_Monuments.First();
        }

        public static ObservableCollection<Monument> SelectFactureLess()
        {
            ObservableCollection<Monument> lst_Monuments = new ObservableCollection<Monument>();
            SqlCommand cmd = new SqlCommand("SELECT Monument.idMonument , Monument.nom , Monument.budget FROM Monument LEFT JOIN Facture ON Monument.idMonument = Facture.idMonument WHERE Facture.idMonument IS NULL;", DBConnector.Connection);
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int idMonument = (int)reader["idMonument"];
                    string nomMonument = (string)reader["nom"];
                    int budgetMonument = (int)reader["budget"];

                    var Monument = new Monument();
                    Monument.ID = idMonument;
                    Monument.Nom = nomMonument;
                    Monument.Budget = budgetMonument;

                    lst_Monuments.Add(Monument);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return lst_Monuments;
        }
    }
}
