using System.Collections.Generic;

namespace Dio.series.Interfaces
{
    public interface IRepositorio<T>  //A classe implementa o repositorio da classe T
    {
        
            List<T> Lista(); //Lista em T
        T RetornaPorid(int id); // retorna o id como paramtro em T 
        void Insere(T entidade);
        void Exclui(int id);
        void Atualizar(int id, T entidade);
        int ProximoId();
    }
}