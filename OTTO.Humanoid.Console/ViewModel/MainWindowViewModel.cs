﻿using System.Collections.Immutable;
using System.ComponentModel;
using Avalonia.Controls;
using Avalonia.Media;
using Mediapipe.Net.Framework.Protobuf;
using SeeShark.Device;

namespace OTTO.Humanoid.Console.ViewModel;

/// <inheritdoc />
public class MainWindowViewModel : INotifyPropertyChanged
{
    /// <summary>
    /// 
    /// </summary>
    public IImage? Image
    {
        get => _image;
        set
        {
            _image = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Image)));
        }
        
    }

    /// <summary>
    /// 
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    public NormalizedLandmarkList Landmarks
    {
        get => _landmarkList;
        set 
        {
            _landmarkList = value;
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(nameof(Landmarks)));
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    public Controls CanvasChildren
    {
        get => _canvasChildren;
        set
        {
            _canvasChildren = value;
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(nameof(CanvasChildren)));
        }
    }

    private Controls _canvasChildren = null!;

    private NormalizedLandmarkList _landmarkList = null!;

    private IImage? _image;
    private ImmutableList<CameraInfo> _camerainfos;

    public ImmutableList<CameraInfo> CameraInfos
    {
        get => _camerainfos;
        set
        {
            _camerainfos = value;
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(nameof(CameraInfos)));
        }
    }
    /// <inheritdoc />
    public event PropertyChangedEventHandler? PropertyChanged;
    
}