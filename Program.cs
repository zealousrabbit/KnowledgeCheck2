 Console.WriteLine("How many records do you want to add? ");
        var numberOfRecords = int.Parse(Console.ReadLine());

        var recordList = new List<RecordCollection>();
        for (int i = 0; i < numberOfRecords; i++)
        {
            // In this loop, populate the object's properties using Console.ReadLine()
            var recordCollection = new RecordCollection();

            Console.WriteLine("Enter the name of the band ");
            recordCollection.bandName = Console.ReadLine();

            Console.WriteLine("Enter the name of the album ");
            recordCollection.albumName = Console.ReadLine();

            Console.WriteLine("Enter the year that the album was released ");
            recordCollection.releaseDate = Console.ReadLine();

            recordList.Add(recordCollection);
        }
        
            Console.Writeline("These are the records in your collection: ");

        // Print out the list of records using Console.WriteLine()
        foreach (var recordCollection in RecordCollection)
        {
            Console.WriteLine({recordCollection.bandName} " " {recordCollection.albumName} " " {recordCollection.releaseDate});
        }
    