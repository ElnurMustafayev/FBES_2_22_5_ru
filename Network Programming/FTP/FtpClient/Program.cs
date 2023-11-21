using FluentFTP;

FtpClient ftpClient = new FtpClient(host: "dewy.fem.tu-ilmenau.de");

ftpClient.Connect();

var files = ftpClient.GetListing(path: "/cdn.media.ccc.de/congress/2017/mp3/");

// foreach (var item in files)
// {
//     System.Console.WriteLine(item.FullName);
// }

var remotePath = files[Random.Shared.Next(0, files.Length)].FullName;
var remoteExtension = Path.GetExtension(remotePath);

System.Console.WriteLine($"Loading {remotePath}...");
ftpClient.DownloadFile(
    localPath: $"rand{remoteExtension}", 
    remotePath: remotePath);



// ftpClient.DownloadFile(
//     localPath: "bob.mp3", 
//     remotePath: "/cdn.media.ccc.de/congress/2017/mp3/34c3-9104-eng-How_Alice_and_Bob_meet_if_they_dont_like_onions.mp3");