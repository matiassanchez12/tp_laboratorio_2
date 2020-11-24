using System;
using Entidades;

//DELEGADO
public delegate void DelegadoCargarDatosNegocio(Negocio negocio, EventArgs e);
public delegate void DelegadoCargarPersona(Persona persona);
public delegate void DelegadoCargarArticulo(Articulo articulo);