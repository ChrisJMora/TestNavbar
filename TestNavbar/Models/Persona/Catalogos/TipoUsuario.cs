﻿namespace TestNavbar.Models.Persona.Catalogos
{
    public class TipoUsuario
    {
        public int Id { get; set; }
        public required string Etiqueta { get; set; }
        public override string ToString()
        {
            return Etiqueta;
        }
    }
}
