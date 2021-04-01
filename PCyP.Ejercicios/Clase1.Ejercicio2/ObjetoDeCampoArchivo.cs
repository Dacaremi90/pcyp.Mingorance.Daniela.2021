using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Ejercicio2
{
    class ObjetoDeCampoArchivo
    {
        private int NumeroDeHoja;
        private string TipoObjeto;
        private int IdentificadorTramo;
        private string TipoCamino;
        private int Longitud;

    public ObjetoDeCampoArchivo()
        {
            NumeroDeHoja = 0;
            TipoObjeto = null;
            IdentificadorTramo = 0;
            TipoCamino = null;
            Longitud = 0;
        }

        public ObjetoDeCampoArchivo(int nroHoja, string Tobje,int IDTramo, string TCamino, int lon)
        {
            NumeroDeHoja = nroHoja;
            TipoObjeto = Tobje;
            IdentificadorTramo = IDTramo;
            TipoCamino = TCamino;
            Longitud = lon;
        }

        public void imprimir()
        {

            Console.WriteLine("Número de hoja: {0}\t Tipo de objeto: {1}\t Identificador de tramo: {2}\t Tipo de camino: {3}\t Longitud: {4}", NumeroDeHoja, TipoObjeto, IdentificadorTramo, TipoCamino, Longitud);

        }


    }
}
