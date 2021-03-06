﻿using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using NAudio.Wave.WaveStreams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LifeTester.Model
{
    public static class PlayerModel
    {
        public static object obj = new object();

        public static Mutex _mu = new Mutex();
        /// <summary>
        /// 开始频率一
        /// </summary>
        public static double StartfrequencyOne { get; set; }
        /// <summary>
        /// 开始频率二
        /// </summary>
        public static double StartfrequencyTwo { get; set; }
        /// <summary>
        /// 结束频率一
        /// </summary>
        public static double EndfrequencyOne { get; set; }
        /// <summary>
        /// 结束频率二
        /// </summary>
        public static double EndfrequencyTwo { get; set; }
        /// <summary>
        /// 扫描时长一
        /// </summary>
        public static double SweepLengthOne { get; set; }
        /// <summary>
        /// 扫描时长二
        /// </summary>
        public static double SweepLengthTwo { get; set; }


        private static bool isCheckSweepOne = false;
        /// <summary>
        /// 判断是否启动扫频一 默认不启动
        /// </summary>
        public static bool IsCheckSweepOne
        {

            get { return isCheckSweepOne; }
            set
            {
                if (isCheckSweepOne != value)
                {
                    isCheckSweepOne = value;
                }
            }
        }

        private static bool isCheckSweepTwo = false;
        /// <summary>
        /// 判断是否启动扫频二 默认不启动
        /// </summary>
        public static bool IsCheckSweepTwo
        {

            get { return isCheckSweepTwo; }
            set
            {
                if (isCheckSweepTwo != value)
                {
                    isCheckSweepTwo = value;
                }
            }
        }

        /// <summary>
        /// 声卡输出一
        /// </summary>
        public static Guid DirectSoundOutDeviceOne { get; set; }

        /// <summary>
        /// 声卡输出二
        /// </summary>
        public static Guid DirectSoundOutDeviceTwo { get; set; }


        /// <summary>
        /// 扫描频率播放器一
        /// </summary>
        public static DirectSoundOut _dsOne = null;
        /// <summary>
        /// 扫描频率播放器二
        /// </summary>
        public static DirectSoundOut _dsTwo = null;
        /// <summary>
        /// 视频文件读取一
        /// </summary>
        public static AudioFileReader afrOne = null;
        /// <summary>
        /// 播放器一
        /// </summary>
        public static LoopStream loopOne = null;
        /// <summary>
        /// 视频文件读取二
        /// </summary>
        public static AudioFileReader afrTwo = null;
        /// <summary>
        /// 播放器二
        /// </summary>
        public static LoopStream loopTwo = null;
        /// <summary>
        /// 信号发生器一
        /// </summary>
        public static SignalGenerator wgOne = null;
        /// <summary>
        /// 信号发生器二
        /// </summary>
        public static SignalGenerator wgTwo = null;
    }
}
