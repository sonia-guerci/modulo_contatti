using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SQLite;

public class ContattoModel : PageModel
{
  [BindProperty] public string Nome { get; set; }
  [BindProperty] public string TestoMessaggio { get; set; }
  public bool Inviato { get; set; }

  public void OnPost()
  {
    Inviato = true;
    using var db = new SQLiteConnection("Data Source=archivio.db");
    db.Open();
    var cmd = new SQLiteCommand("INSERT INTO Messaggi (Nome, Testo) VALUES (@n, @t)", db);
    cmd.Parameters.AddWithValue("@n", Nome);
    cmd.Parameters.AddWithValue("@t", TestoMessaggio);
    cmd.ExecuteNonQuery();
  }
}
