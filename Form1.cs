using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MovieDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dataSet1.MovieDirector' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.movieDirectorTableAdapter.Fill(this.dataSet1.MovieDirector);
            // TODO: Bu kod satırı 'dataSet1.MovieActor' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.movieActorTableAdapter.Fill(this.dataSet1.MovieActor);
            // TODO: Bu kod satırı 'dataSet1.Movie' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.movieTableAdapter.Fill(this.dataSet1.Movie);
            // TODO: Bu kod satırı 'dataSet1.Director' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.directorTableAdapter.Fill(this.dataSet1.Director);
            // TODO: Bu kod satırı 'dataSet1.Actor' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.actorTableAdapter.Fill(this.dataSet1.Actor);

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            actorTableAdapter.Insert(textBox1.Text,textBox2.Text);
            this.actorTableAdapter.Fill(this.dataSet1.Actor);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Actor_ID;
            int.TryParse(comboBox1.SelectedValue.ToString(),out Actor_ID);
            actorTableAdapter.DeleteQuery(Actor_ID);
            this.actorTableAdapter.Fill(this.dataSet1.Actor);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int Actor_ID;
            int.TryParse(comboBox1.SelectedValue.ToString(), out Actor_ID);
            actorTableAdapter.UpdateQuery( textBox1.Text,textBox2.Text,Actor_ID);
            this.actorTableAdapter.Fill(this.dataSet1.Actor);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int Actor_ID;
            int.TryParse( textBox7.Text, out Actor_ID);
            this.actorTableAdapter.Search(this.dataSet1.Actor,Actor_ID);
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            directorTableAdapter.Insert(textBox3.Text,textBox4.Text);
            this.directorTableAdapter.Fill(this.dataSet1.Director);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int Director_ID;
            int.TryParse(comboBox2.SelectedValue.ToString(), out Director_ID);
            this.directorTableAdapter.DeleteQuery(Director_ID);
            this.directorTableAdapter.Fill(this.dataSet1.Director);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int Director_ID;
            int.TryParse(comboBox2.SelectedValue.ToString(), out Director_ID);
            this.directorTableAdapter.UpdateQuery( textBox3.Text,textBox4.Text,Director_ID);
            this.directorTableAdapter.Fill(this.dataSet1.Director);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int Director_ID;
            int.TryParse(textBox8.Text, out Director_ID);
            this.directorTableAdapter.Search(this.dataSet1.Director, Director_ID);
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            movieTableAdapter.Insert(textBox5.Text,textBox6.Text);
            this.movieTableAdapter.Fill(this.dataSet1.Movie);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int Movie_ID;
            int.TryParse(comboBox3.SelectedValue.ToString(), out Movie_ID);
            this.movieTableAdapter.DeleteQuery(Movie_ID);
            this.movieTableAdapter.Fill(this.dataSet1.Movie);
        }

        private void button11_Click(object sender, EventArgs e)
        {

            int Movie_ID;
            int.TryParse(comboBox1.SelectedValue.ToString(), out Movie_ID);
            this.movieTableAdapter.UpdateQuery(textBox5.Text, textBox6.Text, Movie_ID);
            this.movieTableAdapter.Fill(this.dataSet1.Movie);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int Movie_ID;
            int.TryParse(textBox9.Text, out Movie_ID);
            this.movieTableAdapter.Search(this.dataSet1.Movie, Movie_ID);
           
        }

     

        private void button14_Click(object sender, EventArgs e)
        {
            int Enroll_ID;
            int.TryParse(comboBox6.SelectedValue.ToString(), out Enroll_ID);
            movieActorTableAdapter.DeleteQuery(Enroll_ID);
            this.movieActorTableAdapter.Fill(this.dataSet1.MovieActor);
        }

      

     

      

        private void button18_Click(object sender, EventArgs e)
        {
            int Enroll_ID;
            int.TryParse(comboBox7.SelectedValue.ToString(), out Enroll_ID);
            movieActorTableAdapter.DeleteQuery(Enroll_ID);
            this.movieDirectorTableAdapter.Fill(this.dataSet1.MovieDirector);
        }

    
        

        
            
        

        private void button13_Click_1(object sender, EventArgs e)
        {
            int Movie_ID;
            int.TryParse(comboBox4.SelectedValue.ToString(),
            out Movie_ID);
            int Actor_ID;
            int.TryParse(comboBox5.SelectedValue.ToString(), out Actor_ID);
            int Enroll_ID = Movie_ID * 100 + Actor_ID;
            movieActorTableAdapter.Insert(Movie_ID, Actor_ID);
            this.movieActorTableAdapter.Fill(this.dataSet1.MovieActor);
        }
    }
}
