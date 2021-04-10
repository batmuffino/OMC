/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.8
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace LizardTech.LidarSDK {

using System;
using System.Runtime.InteropServices;

public class SimplePointWriter : PointWriter {
  private HandleRef swigCPtr;

  public SimplePointWriter(IntPtr cPtr, bool cMemoryOwn) : base(LidarDSDKPINVOKE.SimplePointWriter_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  public static HandleRef getCPtr(SimplePointWriter obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~SimplePointWriter() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          LidarDSDKPINVOKE.delete_SimplePointWriter(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public virtual void writeBegin(PointInfo pointInfo) {
    LidarDSDKPINVOKE.SimplePointWriter_writeBegin(swigCPtr, PointInfo.getCPtr(pointInfo));
    if (LidarDSDKPINVOKE.SWIGPendingException.Pending) throw LidarDSDKPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void writePoints(PointData points, uint numPoints, ProgressDelegate arg2) {
    LidarDSDKPINVOKE.SimplePointWriter_writePoints(swigCPtr, PointData.getCPtr(points), numPoints, ProgressDelegate.getCPtr(arg2));
    if (LidarDSDKPINVOKE.SWIGPendingException.Pending) throw LidarDSDKPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void writeEnd(long numPoints, Bounds bounds) {
    LidarDSDKPINVOKE.SimplePointWriter_writeEnd(swigCPtr, numPoints, Bounds.getCPtr(bounds));
    if (LidarDSDKPINVOKE.SWIGPendingException.Pending) throw LidarDSDKPINVOKE.SWIGPendingException.Retrieve();
  }

}

}