using MauiAppApiArtists.Models;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace MauiAppApiArtists
{
    public partial class MainPage : ContentPage
    {
        private string ApiUrl = "https://appcloudutnweb.azurewebsites.net/api/Artists";


        public MainPage()
        {
            InitializeComponent();
        }

        private void cmdCreate_Clicked(object sender, EventArgs e)
        {
            var resultado = ConsumeAPI.Crud<Artist>.Create(ApiUrl, new Artist
            {
                Id = 0, // Asignar un ID inicial o dejar que la API lo genere
                Name = txtName.Text,
                LastName = txtLastName.Text,
                Nationality = txtNationality.Text,
                BirthDate = txtBirthDate.Text
            });

            if (resultado != null)
            {
                txtId.Text = resultado.Id.ToString();
            }
        }


        private void cmdRead_Clicked(object sender, EventArgs e)
        {
            var resultado = ConsumeAPI.Crud<Artist>.Read_ById(ApiUrl, int.Parse(txtId.Text));
            if (resultado != null)
            {
                txtId.Text = resultado.Id.ToString();
                txtName.Text = resultado.Name;
                txtLastName.Text = resultado.LastName;
                txtNationality.Text = resultado.Nationality;
                txtBirthDate.Text = resultado.BirthDate;
            }
        }

        private void cmdUpdate_Clicked(object sender, EventArgs e)
        {
            ConsumeAPI.Crud<Artist>.Update(ApiUrl, int.Parse(txtId.Text), new Artist
            {
                Id = int.Parse(txtId.Text),
                Name = txtName.Text,
                LastName = txtLastName.Text,
                Nationality = txtNationality.Text,
                BirthDate = txtBirthDate.Text
            });
        }


        private void cmdDelete_Clicked(object sender, EventArgs e)
        {
            ConsumeAPI.Crud<Artist>.Delete(ApiUrl, int.Parse(txtId.Text));
            txtId.Text = "";
            txtName.Text = "";
            txtLastName.Text = "";
            txtNationality.Text = "";
            txtBirthDate.Text = "";
        }
        private string ApiUrlArtworks = "https://appcloudutnweb.azurewebsites.net/api/Artworks";

        private void cmdCreateArtwork_Clicked(object sender, EventArgs e)
        {
            var resultado = ConsumeAPI.Crud<Artwork>.Create(ApiUrlArtworks, new Artwork
            {
                Id = 0, // Asignar un ID inicial o dejar que la API lo genere
                Name = txtArtworkName.Text,
                PublicationYear = txtPublicationYear.Text,
                Technique = txtTechnique.Text,
                Description = txtDescription.Text,
                ArtistId = int.Parse(txtArtistId.Text)
            });

            if (resultado != null)
            {
                txtArtworkId.Text = resultado.Id.ToString();
            }
        }

        // Método para leer una obra por su ID
        private void cmdReadArtwork_Clicked(object sender, EventArgs e)
        {
            var resultado = ConsumeAPI.Crud<Artwork>.Read_ById(ApiUrlArtworks, int.Parse(txtArtworkId.Text));
            if (resultado != null)
            {
                txtArtworkId.Text = resultado.Id.ToString();
                txtArtworkName.Text = resultado.Name;
                txtPublicationYear.Text = resultado.PublicationYear;
                txtTechnique.Text = resultado.Technique;
                txtDescription.Text = resultado.Description;
                txtArtistId.Text = resultado.ArtistId.ToString();
            }
        }

        // Método para actualizar una obra
        private void cmdUpdateArtwork_Clicked(object sender, EventArgs e)
        {
            ConsumeAPI.Crud<Artwork>.Update(ApiUrlArtworks, int.Parse(txtArtworkId.Text), new Artwork
            {
                Id = int.Parse(txtArtworkId.Text),
                Name = txtArtworkName.Text,
                PublicationYear = txtPublicationYear.Text,
                Technique = txtTechnique.Text,
                Description = txtDescription.Text,
                ArtistId = int.Parse(txtArtistId.Text)
            });
        }

        // Método para eliminar una obra por su ID
        private void cmdDeleteArtwork_Clicked(object sender, EventArgs e)
        {
            ConsumeAPI.Crud<Artwork>.Delete(ApiUrlArtworks, int.Parse(txtArtworkId.Text));
            txtArtworkId.Text = "";
            txtArtworkName.Text = "";
            txtPublicationYear.Text = "";
            txtTechnique.Text = "";
            txtDescription.Text = "";
            txtArtistId.Text = "";
        }
    }

}
