using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JornadaMilhas.Shared.Dados.Data;

public class DAL<T> where T : class
{
    private readonly JornadaMilhasContext context;

    public DAL(JornadaMilhasContext context)
    {
        this.context = context;
    }

    public IEnumerable<T> Listar()
    {
        return context.Set<T>().ToList();
    }
    public T Adicionar(T objeto)
    {
        context.Set<T>().Add(objeto);
        context.SaveChanges();
        return objeto;
    }
    public T Atualizar(T objeto)
    {
        context.Set<T>().Update(objeto);
        context.SaveChanges();
        return objeto;
    }
    public void Remover(T objeto)
    {
        context.Set<T>().Remove(objeto);
        context.SaveChanges();
    }

    public T? RecuperarPor(Func<T, bool> condicao)
    {
        return context.Set<T>().FirstOrDefault(condicao);
    }

    public IEnumerable<T> ListarPor(Func<T, bool> condicao)
    {
        return context.Set<T>().Where(condicao).ToList();
    }
}
