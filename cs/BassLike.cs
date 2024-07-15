using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Un4seen.Bass;

namespace Kasper_3._0.cs
{
    public static class BassLike
    {
        //частота дискретизации
        private static int HZ = 44100;
        //состояние инициализации
        public static bool InitDefaultDevice;
        //канал
        public static int Stream;
        //громкость
        public static int Volume = 1000;
        //инициализация bass.dll
        private static bool initBass(int hz) 
        {
            if (!InitDefaultDevice) 
            {
                InitDefaultDevice = Bass.BASS_Init(-1, hz, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero);
            }
            return InitDefaultDevice;
        }
        //воспроизведение
        public static void Play(string filename, int vol) 
        {
            Stop();
            if (initBass(HZ)) 
            {
                Stream = Bass.BASS_StreamCreateFile(filename, 0, 0, BASSFlag.BASS_DEFAULT);
                if (Stream != 0) 
                {
                    Volume = vol;
                    Bass.BASS_ChannelSetAttribute(Stream, BASSAttribute.BASS_ATTRIB_VOL, Volume / 100);
                    Bass.BASS_ChannelPlay(Stream, false);
                }
            }
        }
        //стоп
        public static void Stop() 
        {
            Bass.BASS_ChannelStop(Stream);
            Bass.BASS_StreamFree(Stream);
        }
        //получение длительности канала в секундах
        public static int GetTimeOfStream(int stream) 
        {
            long TimeBytes = Bass.BASS_ChannelGetLength(stream);
            double Time = Bass.BASS_ChannelBytes2Seconds(stream,TimeBytes);
            return (int)Time;
        }
        //получение текущей позиции в секундах
        public static int GetPosOfStream(int stream) 
        {
            long pos = Bass.BASS_ChannelGetPosition(stream);
            int posSec = (int)Bass.BASS_ChannelBytes2Seconds(stream, pos);
            return posSec;
        }

        public static void SetPosOfScroll(int stream, int pos) 
        {
            Bass.BASS_ChannelSetPosition(stream, (double)pos);
        }
        //установка громкости
        public static void SetVolumeToStream(int stream, int vol) 
        {
            Volume = vol;
            Bass.BASS_ChannelSetAttribute(stream, BASSAttribute.BASS_ATTRIB_VOL, Volume / 100F);
        }


    }
}
