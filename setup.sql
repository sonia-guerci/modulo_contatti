CREATE TABLE IF NOT EXISTS Messaggi (
  Id INTEGER PRIMARY KEY AUTOINCREMENT,
  Nome TEXT NOT NULL,
  Testo TEXT NOT NULL
);

INSERT INTO Messaggi (Nome, Testo) VALUES ('Mario', 'Primo messaggio inviato!');
INSERT INTO Messaggi (Nome, Testo) VALUES ('Lucia', 'Benvenuta nel modulo contatti.');
INSERT INTO Messaggi (Nome, Testo) VALUES ('Giulia', 'Sto testando la funzionalità di invio.');
