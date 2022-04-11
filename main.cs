using System;
using System.IO;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Enter File Name ");
    string file = Console.ReadLine();
    file = "RawGradesFile.txt";
    string text;
    string [] textLine;
    string studentID;
    try{
    StreamReader sr = new StreamReader(file);
    StreamWriter swe = new StreamWriter("ErrorGradesFile.txt");
    StreamWriter swf = new StreamWriter("FinalGradesFile.txt");
    while (!sr.EndOfStream){
    text = sr.ReadLine();
    textLine = text.Split(",");
    studentID = textLine[1];
    if(studentID == null){
          swe.WriteLine(textLine + "bruh");
        }
      else{
        swf.WriteLine(textLine);
      }
      }
    }
    catch (IOException ioex){
      Console.WriteLine("Error: " + ioex);
    }
  }
}
  