class MatrixStylePrint
{
    public string Caption { get; set; }

    public MatrixStylePrint(string caption)
    {
        Caption = caption;
    }

    /// <summary>
    /// Prints text in at a slow pace.
    /// Note: Arguments are not mandatory.
    /// </summary>
    /// <param name="text"></param>
    /// <param name="maxRepetitions"></param>
    public void PrintText(byte maxRepetitions = 1, int sleepTime = 10)
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.DarkGreen;

        Caption.ToUpper();
        PrintLine(Caption, true);
        PrintLine(Caption, false);

        string text = "Ein Entity-Relationship-Modell stellt einen Standard für die Daten-\n"
        + "modellierung dar. Es bildet die Datenstrukturen ab und dient zum einen\n"
        + "in der konzeptionellen Phase der Anwendungsentwicklung der Verständigung\n"
        + "zwischen Anwendern und Entwicklern. Zum anderen ist das ER-Modell in der\n"
        + "Implementierungsphase die Grundlage für das Design der Datenbank.\n\n"
        + "Die Umsetzung der in der Realwelt erkannten Objekte und Beziehungen in ein\n"
        + "Datenbankschema erfolgt dabei in mehreren Schritten (Regeln für die\n"
        + "Entity-Relationship-Modellierung nach Peter Chen):\n\n"
        + "a) Entitäten und Beziehungen identifizieren\n"
        + "b) Identitätsschlüssel für Entitäten bestimmen\n"
        + "c) Festlegen der Entitäts- und Beziehungstypen\n"
        + "d) Festlegen der Beziehungskardinalitäten\n"
        + "e) Attribute und ihre Wertebereiche (Domänen) ermitteln\n"
        + "f) Entity-Relationship-Diagramme (ERD) für Entitäts- und Beziehungsmengen zeichnen\n"
        + "g) Definieren von Primär- und Fremdschlüsseln.\n"
        + "h) Attribute und ihre Wertebereiche in Tabellen eintragen\n\n\n";

        byte counter = 0;

        do
        {
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text[i].ToString());
                Thread.Sleep(sleepTime);
            }
            counter++;
        } while (counter < maxRepetitions);

        Console.ForegroundColor = ConsoleColor.Gray;
    }

    /// <summary>
    /// Prints the caption, if isFirstLine = true;
    /// prints an underline, if isFirstLine = false.
    /// </summary>
    /// <param name="caption"></param>
    /// <param name="isFirstLine"></param>
    private void PrintLine(string caption, bool isFirstLine)
    {
        if (isFirstLine)
        {
            for (int i = 0; i < caption.Length; i++)
            {
                Console.Write(caption[i]);
                Thread.Sleep(10);
            }
            Console.WriteLine();
        }
        else
        {
            for (int i = 0; i < caption.Length; i++)
            {
                Console.Write('=');
                Thread.Sleep(10);
            }
            Console.WriteLine("\n");
        }
    }
}