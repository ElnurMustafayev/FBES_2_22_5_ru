namespace AbstractionApp;

public abstract class FileExplorerObject {
    public abstract string Name { get; }

    public abstract int GetSize();
}



public class MyFile : FileExplorerObject {
    public string Content = string.Empty;
    public string Filename { get; set; }
    public string FileExtension { get; set; }

    public MyFile(string filename, string fileExtension) {
        Filename = filename;
        FileExtension = fileExtension;
    }

    public override int GetSize() => this.Content.Length * 2;

    public override string Name => $"{Filename}.{FileExtension}";
}



public class MyFolder : FileExplorerObject {
    private List<MyFile> myFiles = new List<MyFile>();
    public string Foldername { get; set; }
    public override string Name => Foldername;


    public MyFolder(string foldername) {
        Foldername = foldername;
    }

    public void AddFile(MyFile file) {
        this.myFiles.Add(file);
    }

    public override int GetSize() {
        int size = 0;

        for (int i = 0; i < this.myFiles.Count; i++) {
            size += this.myFiles[i].GetSize();
        }

        return size;
    }
}