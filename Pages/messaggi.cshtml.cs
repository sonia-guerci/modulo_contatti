using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;

public class MessaggiModel : PageModel
{
  public List<(int Id, string Nome, string Testo)> Messaggi { get; set; }

  public void OnGet()
  {
    Messaggi = new();

    if (!System.IO.File.Exists("archivio.db"))
    {
      System.IO.File.Create("archivio.db").Dispose();
      using var db = new SQLiteConnection("Data Source=archivio.db");
      db.Open();
      var script = System.IO.File.ReadAllText("setup.sql");
      var cmd = new SQLiteCommand(script, db);
      cmd.ExecuteNonQuery();
    }

    using var db2 = new SQLiteConnection("Data Source=archivio.db");
    db2.Open();
    var cmd2 = new SQLiteCommand("SELECT Id, Nome, Testo FROM Messaggi", db2);
    using var reader = cmd2.ExecuteReader();
    while (reader.Read())
    {
      Messaggi.Add((reader.GetInt32(0), reader.GetString(1), reader.GetString(2)));
    }
  }

  public IActionResult OnPost(int Id)
  {
    if (Id <= 0)
    {
      return BadRequest("Invalid message ID.");
    }
    using var db = new SQLiteConnection("Data Source=archivio.db");
    db.Open();
    var cmd = new SQLiteCommand("DELETE FROM Messaggi WHERE Id = @id", db);
    cmd.Parameters.AddWithValue("@id", Id);
    cmd.ExecuteNonQuery();
    return RedirectToPage();
  }
}

