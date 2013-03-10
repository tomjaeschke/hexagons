using System;
using Damisam.Objects;

namespace Damisam.UserInterface
{
    public partial class Default : System.Web.UI.Page
    {
        public SimpleTerritory Model;
        
        public void Page_Load(object sender, EventArgs e)
        {
            int hexagon = 0;
            Instructions.Text = "enter a positive integer of up to five digits";
            if(Request.QueryString["hexagon"] != null)
            {
                string wouldBeValue = Request.QueryString["hexagon"] as string;
                try
                {
                    hexagon = Convert.ToInt32(wouldBeValue);
                    if (hexagon < 0 || hexagon > 99999)
                    {
                        if (Request.QueryString["moveby"] != null && Request.QueryString["moveby"] as string == "arrow" && hexagon > 0)
                        {
                            if (!Page.IsPostBack) TextBox.Text = "";
                        } else {
                            if (!Page.IsPostBack) TextBox.Text = "";
                            hexagon = 0;
                            Instructions.Text = "you DID NOT enter a positive integer of up to five digits";
                        }
                    }
                }
                catch
                {
                    if (!Page.IsPostBack) TextBox.Text = "";
                    hexagon = 0;
                    Instructions.Text = "you DID NOT enter a positive integer of up to five digits";
                }
            }
            Model = new SimpleTerritory(hexagon);
            Hexagon.Text = Model.Hexagon.ToString();
            HexagonToTheEast.Text = Model.HexagonToTheEast.ToString();
            HexagonToTheSouthBySoutheast.Text = Model.HexagonToTheSouthBySoutheast.ToString();
            HexagonToTheSouthBySouthwest.Text = Model.HexagonToTheSouthBySouthwest.ToString();
            HexagonToTheWest.Text = Model.HexagonToTheWest.ToString();
            HexagonToTheNorthByNorthwest.Text = Model.HexagonToTheNorthByNorthwest.ToString();
            HexagonToTheNorthByNortheast.Text = Model.HexagonToTheNorthByNortheast.ToString();
            Color.Text = Model.Color;
        }

        protected void Button_Click(Object sender, EventArgs e)
        {
            if (TextBox.Text.Trim() != "")
            {
                Response.Redirect("Default.aspx?hexagon=" + TextBox.Text.Trim());
            } else {
                Response.Redirect("Default.aspx?hexagon=0");
            }
        }
    }
}