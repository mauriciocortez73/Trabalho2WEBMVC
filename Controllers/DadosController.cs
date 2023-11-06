using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Trabalho2WEBMVC.Models;

namespace Trabalho2WEBMVC.Controllers
{
    public class DadosController : Controller
    {
        private readonly Contexto contexto;

        public DadosController(Contexto context)
        {
            contexto = context;
        }

        public IActionResult gerarClientes()
        {
            contexto.Database.ExecuteSqlRaw("delete from Clientes");
            contexto.Database.ExecuteSqlRaw("DBCC CHECKIDENT ('Clientes', RESEED, 0)");
            Random randNum = new Random();

            string[] vNomeMas = { "Miguel",  "Arthur", "Gael", "Théo", "Heitor", "Ravi", "Davi", "Bernardo", "Noah", "Gabriel", "Samuel", "Pedro", "Anthony", "Isaac", "Benício", "Benjamin", "Matheus", "Lucas", "Joaquim", "Nicolas", "Lucca", "Lorenzo", "Henrique", "João Miguel", "Rafael", "Henry", "Murilo", "Levi", "Guilherme", "Vicente", "Felipe", "Bryan", "Matteo", "Bento", "João Pedro", "Pietro", "Leonardo", "Daniel", "Gustavo", "Pedro Henrique", "João Lucas", "Emanuel", "João", "Caleb", "Davi Lucca", "Antônio", "Eduardo", "Enrico", "Caio", "José", "Enzo Gabriel", "Augusto", "Mathias", "Vitor", "Enzo", "Cauã", "Francisco", "Rael", "João Guilherme", "Thomas", "Yuri", "Yan", "Anthony Gabriel", "Oliver", "Otávio", "João Gabriel", "Nathan", "Davi Lucas", "Vinícius", "Theodoro", "Valentim", "Ryan", "Luiz Miguel", "Arthur Miguel", "João Vitor", "Léonovo", "Ravi Lucca", "Apollo", "Thiago", "Tomás", "Martin", "José Miguel", "Erick", "Liam", "Josué"};
            string[] vNomeFem = { "Helena", "Alice", "Laura", "Maria Alice", "Sophia", "Manuela", "Maitê", "Liz", "Cecília", "Isabella", "Luísa", "Eloá", "Heloísa", "Júlia", "Ayla", "Maria Luísa", "Isis", "Elisa", "Antonella", "Valentina", "Maya", "Maria Júlia", "Aurora", "Lara", "Maria Clara", "Lívia", "Esther", "Giovanna", "Sarah", "Maria Cecília", "Lorena", "Beatriz", "Rebeca", "Luna", "Olívia", "Maria Helena", "Mariana", "Isadora", "Melissa", "Maria", "Catarina", "Lavínia", "Alícia", "Maria Eduarda", "Agatha", "Ana Liz", "Yasmin", "Emanuelly", "Ana Clara", "Clara", "Ana Júlia", "Marina", "Stella", "Jade", "Maria Liz", "Ana Laura", "Maria Isis", "Ana Luísa", "Gabriela", "Alana", "Rafaela", "Vitória", "Isabelly", "Bella", "Milena" };
            string[] vDominio = { "UOL", "Gmail", "FEMA", "Globo", "yahoo"};

            for (int i = 0; i < 10; i++) 
            { 
                Cliente cliente = new Cliente();
                cliente.nome = (i % 2 == 0) ? vNomeMas[i / 2] : vNomeFem[i / 2];
                cliente.email = cliente.nome.ToLower() + "@" + vDominio[randNum.Next()%5].ToLower() + ".com.br";
                cliente.unidadesID = randNum.Next(1, 5);
                contexto.Clientes.Add(cliente);
            }
            contexto.SaveChanges();

            return View(contexto.Clientes.OrderBy(o=>o.nome).ToList());
        }

        public IActionResult gerarUnidades()
        {
            contexto.Database.ExecuteSqlRaw("delete from Unidades");
            contexto.Database.ExecuteSqlRaw("DBCC CHECKIDENT ('Unidades', RESEED, 0)");
            Random randNum = new Random();
            string[] vUni = { "Dell EMC", "SAP Labs Latin America", "SAP Brasil", "CI&T", "Vivo", "Oracle do Brasil", "Logicalis", "INTELBRAS", "Mercado Livre", "Getnet", "ALGAR TELECOM", "IBM Brasil", "Clear Sale", "Cielo", "Cognizant Brasil", "Nextel", "Atento Brasil", "Algar Tech", "Teleperformance", "SENIOR SISTEMAS" };

            for (int i = 0; i < 5; i++) 
            { 
                Unidade unidade = new Unidade();
                unidade.descricao = vUni[i];
                unidade.cnpj = randNum.Next(1, 99).ToString() + "." + randNum.Next(100, 999).ToString() + "." + randNum.Next(100, 999).ToString() + "/0001-" +  randNum.Next(1, 99).ToString();
                contexto.Unidades.Add(unidade);
            }
            contexto.SaveChanges();

            return View(contexto.Unidades.OrderBy(o => o.descricao).ToList());
        }
    }
}
