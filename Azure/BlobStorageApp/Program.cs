using Azure.Storage.Blobs;

const string connectionString = "";

var blobServiceClient = new BlobServiceClient(connectionString);

// get all containers
/*
await foreach (var container in blobServiceClient.GetBlobContainersAsync())
{
    System.Console.WriteLine(container.Name);
}
*/

// create container
/*
var createBlobContainerResponse = await blobServiceClient.CreateBlobContainerAsync("testcontainer", PublicAccessType.BlobContainer);
var blobContainerClient = createBlobContainerResponse.Value;
System.Console.WriteLine(blobContainerClient);
*/

/*
var containerClient = blobServiceClient.GetBlobContainerClient("mycontainer");
await foreach(var blob in containerClient.GetBlobsAsync()) {
    System.Console.WriteLine(blob.Name);
}
*/

// var containerClient = blobServiceClient.GetBlobContainerClient("mycontainer");
// var blobClient = containerClient.GetBlobClient("Default.jpg");

// using var fileStream = File.Create($"{Guid.NewGuid().ToString("N")}.jpg");
// var response = await blobClient.DownloadToAsync(fileStream);
// System.Console.WriteLine(response);





// var containerClient = blobServiceClient.GetBlobContainerClient("mycontainer");
// await foreach(var blob in containerClient.GetBlobsAsync()) {
//     var blobClient = containerClient.GetBlobClient(blob.Name);

//     using var fileStream = File.Create(blob.Name);
//     var response = await blobClient.DownloadToAsync(fileStream);
//     fileStream.Close();
// }



// var containerClient = blobServiceClient.GetBlobContainerClient("testcontainer");
// var blobClient = containerClient.GetBlobClient("Default.jpg");

// using var fileStream = File.Open("bob.jpg", FileMode.Open);
// await blobClient.UploadAsync(fileStream);
// fileStream.Close();






var files = Directory.GetFiles(".");// .Where(f => f.EndsWith(".jpg"));
var containerClient = blobServiceClient.GetBlobContainerClient("testcontainer");

foreach (var file in files)
{
    var normalizedFilePath = file.TrimStart('.', '/');
    var blobClient = containerClient.GetBlobClient(normalizedFilePath);
    using var fileStream = File.Open(file, FileMode.Open);
    await blobClient.UploadAsync(fileStream);
    fileStream.Close();
}