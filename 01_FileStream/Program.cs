// FileStream - потоковий клас, для роботи з  файлами на низькому рівні,
// може читати-писати байт або масив байтів
string path = "../../../my.dat"; // буде бінарний файл, розміщений у папці проекту

// using = блок, який забезпечує автоматичне звільнення ресурсів після завершення роботи з ними, навіть якщо виникнуть виключення.
using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.ReadWrite))
{
    byte val = 97; // 'a'
    byte[] bytes = { 65, 66, 67, 68, 69, 70 };// коди символів ABCDEF
    fs.WriteByte(val); // пишемо 1 байт - 'a'
    // fs.Write(bytes, 0, 4); // ABCD
    fs.Write(bytes); // ABCDEF
    Console.WriteLine($"_________File Length____ {fs.Length}___");

    if (fs.CanRead)
    {
        fs.Position = 0; // встановили файл курсор на  ПОЧАТОК файлу
        byte[] read = new byte[fs.Length];
        int countBytes = fs.Read(read);
        Console.WriteLine($"Read {countBytes} bytes : ");
        foreach (var item in read)
        {
            Console.Write($"{item,5}");
        }
    }
    else
        Console.WriteLine("Cannot read!!!!");
    // fs.Close(); // закриває потік і звільняє всі ресурси, пов'язані з потоком. Після виклику Close() потік більше не може бути використаний для читання або запису даних.
    //fs.Dispose(); // звільняє всі ресурси, пов'язані з потоком, включаючи закриття потока. Після виклику Dispose() потік більше не може бути використаний для читання або запису даних.
} // після виходу з блоку using, об'єкт FileStream буде автоматично закритий і звільняться всі ресурси, пов'язані з файлом.