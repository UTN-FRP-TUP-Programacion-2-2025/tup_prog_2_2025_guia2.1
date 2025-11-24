using Ejercicio1.Models;

namespace Ejercicio1;

public partial class FormPrincipal : Form
{
    DepartamentoVehicular dpto = new DepartamentoVehicular();

    public FormPrincipal()
    {
        InitializeComponent();
    }

    private void btnRegistrar_Click(object sender, EventArgs e)
    {
        Persona persona = new Persona(43402034,"Luisa");
        RegistroVehiculo reg=dpto.RegistrarVehiculo(persona);
                   
        tbImpresoRegistro.Text=reg.VerDetalle();
    }

    private void btnListar_Click(object sender, EventArgs e)
    {
     
        lbxRegistros.Items.Clear();
        for (int idx = 0; idx < dpto.CantidadRegistros; idx++)
        {
            RegistroVehiculo reg = dpto.VerRegistro(idx);                
            lbxRegistros.Items.Add(reg.VerDetalle());
        }
    }
}
