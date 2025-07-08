# 📬 Modulo Contatti – Razor Pages + SQLite (.NET 8)

Template didattico basato su ASP.NET Core Razor Pages, con database SQLite creato e popolato tramite script SQL esterno (`setup.sql`).  
Funziona 100% online con [GitHub Codespaces](https://github.com/features/codespaces) — zero installazioni!

---

## 🧪 Apri subito in Codespaces

[![Apri in Codespaces](https://github.com/codespaces/badge.svg)](https://github.com/codespaces/new?template_repository=sonia-guerci/modulo_contatti)

🔹 Il repository è un **template**: puoi usarlo per generare una copia personale, senza fare fork manuale.

---

## ✅ Avvio rapido

1. Clicca su **"Open in Codespaces"**
2. Attendi il caricamento dell’ambiente online (VS Code Web)
3. Apri il terminale integrato (CTRL+J) e digita:


``` bash
dotnet run
```
 oppure premi il tasto Play (Debug).

4. Visita nel browser:
- **Codespaces**: Trova l'URL pubblico generato automaticamente nella sezione "PORTS" di VS Code (esempio: `https://<your-codespace-name>-8080.githubpreview.dev`).
- **Localhost** (se eseguito localmente):
`http://localhost:8080/contatto` → modulo invio messaggio
`http://localhost:8080/messaggi` → elenco dei messaggi ricevuti

---

## 🧠 Inizializzazione database

Alla prima esecuzione:
- Se non esiste `archivio.db`, viene creato automaticamente.
- Viene eseguito lo script `setup.sql`, che crea la tabella e inserisce dati demo.

✅ Nessuna dipendenza esterna  
✅ Database e struttura già pronti per lavorare

---

## 📚 Tecnologie usate

- ASP.NET Core 8 + Razor Pages
- SQLite (`archivio.db`) + script SQL esterno
- Devcontainer per avvio automatico in Codespaces
- HTML/CSS per la UI

---

## 👩‍🎓 Salvataggio del lavoro (per studenti)

Puoi salvare il tuo lavoro in un **nuovo repository GitHub**:

1. Apri il pannello **Source Control** (icona ramo Git)
2. Scrivi un messaggio (es: `modifica form`)
3. Premi **Commit**
4. Poi clicca su **Publish Branch**
5. GitHub ti chiederà: “Create a new repository?”
6. Dai un nome → fatto! 🎉

✅ Nessuna configurazione manuale  
✅ Nessun fork obbligatorio

---

## 🧭 Utilizzo duale: Codespaces + GitHub Classroom

Questo progetto può essere usato in **due modalità complementari**:

### 💻 1. Uso libero in Codespaces

- Clic su “Open in Codespaces”
- Avvio automatico del progetto via browser
- Modifiche e salvataggio in repo personale

### 🏫 2. Come compito di GitHub Classroom

- Gli studenti ricevono un link assignment da GitHub Classroom
- Il progetto viene duplicato come repository privato individuale
- Funziona in Codespaces o offline

✅ Mantieni un solo template centrale  
✅ Multiuso per esercizi e lavoro libero

---

## 💙 Credits

Creato per ambienti educativi con supporto Microsoft Copilot  
Distribuibile liberamente a scopo didattico
