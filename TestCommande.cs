using Atulam_Appels.Interfaces;
using Atulam_Appels.Services;
using ControlsBase;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtulamAdmin
{
    public partial class TestCommande : Atulam_Fiche
    {

        public class ContenuGrille
        {
            public string Code { get; set; }

            public List<(string Libelle, int Valeur)> Valeurs { get; set; } = new List<(string Libelle, int Valeur)>();
        }

        List<ContenuGrille> source = new List<ContenuGrille>();

        IAtulamApiGeneral atulamApiGeneral = new AtulamApiGeneral();

        public TestCommande()
        {
            InitializeComponent();
            Load += TestCommande_Load;
        }

        private void TestCommande_Load(object sender, EventArgs e)
        {

            List<String> indicateurs = new List<string>() { "A1", "A2" }; // Define in DataBase, the developper don't know how many 'indicateurs' the source have

            // For each Code, we have all the 'indicateurs' with a value
            source.Add(new ContenuGrille() { Code = "A", Valeurs = GenerateValue(indicateurs) });
            source.Add(new ContenuGrille() { Code = "B", Valeurs = GenerateValue(indicateurs) });

            grille.DataSource = source;
            gv.Columns.Clear();
            int indice = 0;
            grille.AjouteColonne(gv, "Code", "Code", indice++);
            //foreach (var ind in source[0].Valeurs)
            //{
            //    DevExpress.XtraGrid.Columns.GridColumn gc = AjouteColonneGeneral(gv, "Valeurs[" + ind.Libelle + "]", ind.Libelle);

            //    //gc.FieldName = ""  ?? 
            //}
        }

        private DevExpress.XtraGrid.Columns.GridColumn AjouteColonneGeneral(GridView myView, string name, string caption, string field)
        {
            return new DevExpress.XtraGrid.Columns.GridColumn()
            {
                Name = name,
                Caption = caption,
                FieldName = field
            };
        }



        private List<(string Libelle, int Valeur)> GenerateValue(List<string> indicateurs)
        {
            var rand = new Random();

            List<(string Libelle, int Valeur)> values = new List<(string Libelle, int Valeur)>();
            foreach (var ind in indicateurs)
                values.Add((ind, rand.Next(0, 10)));
            return values;
        }
    }
}
