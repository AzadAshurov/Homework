using System;
using System.Threading;

class Program
{
    static void Main()
    {
        while (true) // Бесконечный цикл для воспроизведения мелодии
        {
            PlayMelody();
            Thread.Sleep(500); // Пауза перед повторным воспроизведением
        }
    }

    static void PlayMelody()
    {
        int[] frequencies = { 523, 587, 659, 523 }; // Частоты нот (C, D, E, C)
        int duration = 300; // Продолжительность каждой ноты в миллисекундах

        foreach (int frequency in frequencies)
        {
            Console.Beep(frequency, duration);
            Thread.Sleep(50); // Пауза между нотами
        }
    }
}
