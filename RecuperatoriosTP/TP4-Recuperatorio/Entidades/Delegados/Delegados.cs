using System;
using Entidades;

//DELEGADOS
/// <summary>
/// Delegado para generar un ticket
/// </summary>
/// <param name="parametro">Recibe un articulo</param>
/// <returns>True si pudo generar el articulo, false caso contrario</returns>
public delegate bool DelegadoGenerarTicket(Articulo parametro);

/// <summary>
/// Delegado para cargar un cliente
/// </summary>
/// <param name="cliente">Recibe un cliente</param>
public delegate void DelegadoCargarCliente(Cliente cliente);

/// <summary>
/// Delegado para cargar un articulo
/// </summary>
/// <param name="articulo">Recibe un articulo</param>
public delegate void DelegadoCargarArticulo(Articulo articulo);

