/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.9
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace org.doubango.ultimateMicr.Sdk {

using System;
using System.Runtime.InteropServices;

public class UltMicrSdkResult : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal UltMicrSdkResult(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(UltMicrSdkResult obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~UltMicrSdkResult() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ultimateMicrSdkPINVOKE.delete_UltMicrSdkResult(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public UltMicrSdkResult() : this(ultimateMicrSdkPINVOKE.new_UltMicrSdkResult__SWIG_0(), true) {
  }

  public UltMicrSdkResult(int code, string phrase, string json, uint numZones) : this(ultimateMicrSdkPINVOKE.new_UltMicrSdkResult__SWIG_1(code, phrase, json, numZones), true) {
  }

  public UltMicrSdkResult(int code, string phrase, string json) : this(ultimateMicrSdkPINVOKE.new_UltMicrSdkResult__SWIG_2(code, phrase, json), true) {
  }

  public UltMicrSdkResult(UltMicrSdkResult other) : this(ultimateMicrSdkPINVOKE.new_UltMicrSdkResult__SWIG_3(UltMicrSdkResult.getCPtr(other)), true) {
    if (ultimateMicrSdkPINVOKE.SWIGPendingException.Pending) throw ultimateMicrSdkPINVOKE.SWIGPendingException.Retrieve();
  }

  public int code() {
    int ret = ultimateMicrSdkPINVOKE.UltMicrSdkResult_code(swigCPtr);
    return ret;
  }

  public string phrase() {
    string ret = ultimateMicrSdkPINVOKE.UltMicrSdkResult_phrase(swigCPtr);
    return ret;
  }

  public string json() {
    string ret = ultimateMicrSdkPINVOKE.UltMicrSdkResult_json(swigCPtr);
    return ret;
  }

  public uint numZones() {
    uint ret = ultimateMicrSdkPINVOKE.UltMicrSdkResult_numZones(swigCPtr);
    return ret;
  }

  public bool isOK() {
    bool ret = ultimateMicrSdkPINVOKE.UltMicrSdkResult_isOK(swigCPtr);
    return ret;
  }

}

}
