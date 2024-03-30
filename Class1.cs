using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        if (string.IsNullOrEmpty(title) || title.Length > 200)
        {
            throw new ArgumentException("Judul video harus memiliki panjang maksimal 200 karakter dan tidak boleh null.");
        }

        this.id = GenerateRandomId();
        this.title = title;
        this.playCount = 0;
    }
    public void IncreasePlayCount(int countToAdd)
    {
        Contract.Requires<ArgumentOutOfRangeException>(countToAdd is >= 0 and <= 10_000_000, "Input penambahan play count harus antara 0 dan 10.000.000.");

        try
        {
            checked
            {
                this.playCount += countToAdd;
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Overflow terdeteksi. Jumlah penambahan play count melebihi batas maksimum.");
        }
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine($"Video Details: ");
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Play Count: {playCount}");
    }

    private int GenerateRandomId()
    {
        Random rand = new Random();
        return rand.Next(10000, 99999);
    }
    public int getPlayCount(SayaTubeVideo video)
    {
        return 0;
    }
}
