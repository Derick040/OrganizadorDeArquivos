using System;
using System.IO;

string directory = GetDirectory();

string[] files = Directory.GetFiles(directory);

foreach (string file in files)
{
    string extension = Path.GetExtension(file);
    string fileName = Path.GetFileName(file);

    string destinationDirectory = "";

    switch (extension)
    {
        case ".txt":
        case ".pdf":
            destinationDirectory = "/home/derick33/Documentos/";
            break;

        case ".jpg":
        case ".jpeg":
        case ".png":
            destinationDirectory = "/home/derick33/Imagens/";
            break;
    }
    
    if (destinationDirectory != "") {

        Directory.CreateDirectory(destinationDirectory);

        string finalPath = Path.Combine(destinationDirectory, fileName);

        File.Move(file, finalPath);
    }
}

string GetDirectory()
{
    return "/home/derick33/Downloads/Testes";
}