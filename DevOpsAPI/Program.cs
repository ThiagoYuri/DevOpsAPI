using DevOpsAPI;
using Microsoft.TeamFoundation.WorkItemTracking.WebApi.Models;

QueryExecutor query = new QueryExecutor("organization","token");

//Task<IList<WorkItem>> workItens = query.QueryOpenBugs("Vitrine de Projetos");
await query.PrintOpenBugsAsync("Name Project");

Console.ReadKey();