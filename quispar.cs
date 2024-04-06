var foldersWithFiles = await Task.WhenAll(folders.Select(folder => Task.Run(async () =>
{
    // Assuming 'GetFilesAsync' is a method that retrieves files from a folder
    var files = await GetFilesAsync(folder);
    return new { Folder = folder, Files = files };
})));
