﻿using System;
using CommunityToolkit.Mvvm.ComponentModel;
using OpenCvSharp;

namespace BetterGenshinImpact.Core.Config
{
    /// <summary>
    /// 遮罩窗口配置
    /// </summary>
    [Serializable]
    public partial class MaskWindowConfig : ObservableObject
    {
        /// <summary>
        /// 是否启用遮罩窗口
        /// </summary>
        [ObservableProperty] private bool _enableMaskWindow = true;

        /// <summary>
        /// 是否在遮罩窗口上显示识别结果
        /// </summary>
        [ObservableProperty] private bool _displayRecognitionResultsOnMaskWindow = true;

        /// <summary>
        /// 显示遮罩窗口边框
        /// </summary>
        [ObservableProperty] private bool _showMaskWindowBorder = false;

        /// <summary>
        /// 显示日志窗口
        /// </summary>
        [ObservableProperty] private bool _showLogBox = true;

        /// <summary>
        /// 日志窗口位置与大小
        /// </summary>
        [ObservableProperty] private Rect _logBoxLocation = Rect.Empty;

        /// <summary>
        /// 控件是否锁定（拖拽移动等）
        /// </summary>
        [ObservableProperty] private bool _controlLocked = false;
    }
}