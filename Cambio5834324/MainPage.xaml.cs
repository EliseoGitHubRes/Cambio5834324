namespace Cambio5834324;

public partial class MainPage : ContentPage
{
    /// <summary>
    /// <Createddate>27/07/2023</Createddate>
    /// <company>INDEL</company>
    /// <lastmodificationdate>27/07/2023</lastmodificationdate>
    /// <lastmodificationdescription>
    /// PROPIEDADES DE LA IMAGEN
    /// </lastmodificationdescription>
    /// <lastmodifierautor>ELISEO</lastmodifierautor>
    /// </summary>
	public MainPage()
	{
		InitializeComponent();
	}

    /// <summary>
    /// SE EJECUTA AL PRESIONAR EL BOTON
    /// </summary>
    private void Button_Clicked(object sender, EventArgs e)
    {
        double costo = Convert.ToDouble(costoArt.Text);
        double dinero = Convert.ToDouble(dinerocli.Text);

        double cambio = dinero - costo;

        cambioCli.Text = "EL cambio es: $" + cambio;
    }
}

