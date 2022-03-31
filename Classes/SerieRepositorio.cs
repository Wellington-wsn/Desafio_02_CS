using System;
using System.Collections.Generic;
using Dio.series.Interfaces;

namespace Dio.series
{
    public class SerieRepositorio : IRepositorio<Serie> //imprementar o Irepositorio da classe Serie
    {
        private List<Serie> listaSerie = new List<Serie>(); //lista para usar em repositorio, serviços em camadas; representa o BD em memoria

        //implementação dos métodos da interface
        public void Atualizar(int id, Serie objeto)
        {
            listaSerie[id] = objeto; 
        }

        public void Exclui(int id)
        {
            listaSerie[id].Excluir();
            //implementa envio de email
        }

        public void Insere(Serie objeto)
        {
            listaSerie.Add(objeto);
        }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count; // coleção é baseada em 0, retorno sempre a qtd da lista
        }

        public Serie RetornaPorid(int id)
        {
            return listaSerie[id];
        }
    }
}