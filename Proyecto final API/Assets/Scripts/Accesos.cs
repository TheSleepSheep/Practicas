using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;
using Unity.VisualScripting;

public class Accesos : MonoBehaviour
{
    public GameObject Panelacceder;
    public GameObject Pantallaprincipal;

    public GameObject panelAlertas;
    public string[] textoAlertas;

    public List<string> usuarios = new List<string>();
    public List<string> contras = new List<string>();

    public TMP_InputField nombreUsuario;
    public TMP_InputField NuevoUsuario;

    public TMP_InputField Contrasena;
    public TMP_InputField NuevaContrasena;

    public TMP_Text alertasDisplay;
    public TMP_Text nombreUsuarioDisplay;


    void Start()
    {
        usuarios.Add(item: "Bonnie");
        contras.Add(item: "12345");
    }

    public void AccerderConUsuario()
    {
        Debug.Log("Accediendo con Usuario...");

        if (usuarios.Contains(nombreUsuario.text))
        {
            panelAlertas.SetActive(true);

            nombreUsuarioDisplay.text = nombreUsuario.text;
            Debug.Log("Nombre de Usuario: " + nombreUsuarioDisplay.text);

        }
        else
        {
            panelAlertas.SetActive(true);
            alertasDisplay.text = textoAlertas[0];
        }
    }

    public void CrearUsuario()
    {
        if (usuarios.Contains(NuevoUsuario.text))
        {
            panelAlertas.SetActive(true);
            alertasDisplay.text = textoAlertas[1];
        }
        else
        {
            usuarios.Add(NuevoUsuario.text);
            panelAlertas.SetActive(true);
            alertasDisplay.text = textoAlertas[2];
        }
    }

    public void AccederContrasena()
    {
        if (contras.Contains(Contrasena.text))
        {
            Debug.Log("Accediendo con contraseņa...");

            panelAlertas.SetActive(true);
            Panelacceder.SetActive(false);
            Pantallaprincipal.SetActive(true);
        }
        else
        {
            panelAlertas.SetActive(true);
            alertasDisplay.text = textoAlertas[3];
        }
    }

    public void CrearContrasena()
    {
        if (contras.Contains(NuevaContrasena.text))
        {
            panelAlertas.SetActive(true);
        }
        else
        {
            contras.Add(NuevaContrasena.text);
            panelAlertas.SetActive(true);
        }

    }

}
