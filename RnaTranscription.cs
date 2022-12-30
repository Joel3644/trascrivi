using System;
using System.Collections.Generic;
using System.Text;

public static class TrascrizioneRNA
{
    public static string ToRna(string dna)
    {
        string rna = "";
        if( String.IsNullOrEmpty( dna ) )
            return "";

        foreach(char c in dna){
            switch(c){
                case 'G':
                    rna += "C";
                break;
                case 'C':
                    rna += "G";
                break;
                case 'T':
                    rna += "A";
                break;
                case 'A':
                    rna += "U";
                break;
                default:
                    Console.WriteLine("Errore");
                break;
            }
        }
        return rna;
    }
}