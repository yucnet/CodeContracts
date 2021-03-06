// CodeContracts
// 
// Copyright (c) Microsoft Corporation
// 
// All rights reserved. 
// 
// MIT License
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

// File System.ComponentModel.Composition.Hosting.ExportProvider.cs
// Automatically generated contract file.
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Diagnostics.Contracts;
using System;

// Disable the "this variable is not used" warning as every field would imply it.
#pragma warning disable 0414
// Disable the "this variable is never assigned to".
#pragma warning disable 0067
// Disable the "this event is never assigned to".
#pragma warning disable 0649
// Disable the "this variable is never used".
#pragma warning disable 0169
// Disable the "new keyword not required" warning.
#pragma warning disable 0109
// Disable the "extern without DllImport" warning.
#pragma warning disable 0626
// Disable the "could hide other member" warning, can happen on certain properties.
#pragma warning disable 0108


namespace System.ComponentModel.Composition.Hosting
{
  abstract public partial class ExportProvider
  {
    #region Methods and constructors
    protected ExportProvider()
    {
    }

    public Lazy<T, TMetadataView> GetExport<T, TMetadataView>()
    {
      return default(Lazy<T, TMetadataView>);
    }

    public Lazy<T> GetExport<T>()
    {
      return default(Lazy<T>);
    }

    public Lazy<T, TMetadataView> GetExport<T, TMetadataView>(string contractName)
    {
      return default(Lazy<T, TMetadataView>);
    }

    public Lazy<T> GetExport<T>(string contractName)
    {
      return default(Lazy<T>);
    }

    public T GetExportedValue<T>(string contractName)
    {
      Contract.Ensures(Contract.Result<T>() != null); 
      // because of ImportCardinality.ExactlyOne =>
      // return this.GetExportedValueCore<T>(contractName, ImportCardinality.ExactlyOne);
      return default(T);
    }

    public T GetExportedValue<T>()
    {
      Contract.Ensures(Contract.Result<T>() != null);
      return this.GetExportedValue<T>((string)null);
    }

    public T GetExportedValueOrDefault<T>()
    {
      return default(T);
    }

    public T GetExportedValueOrDefault<T>(string contractName)
    {
      return default(T);
    }

    public IEnumerable<T> GetExportedValues<T>(string contractName)
    {
      Contract.Ensures(Contract.Result<System.Collections.Generic.IEnumerable<T>>() != null);

      return default(IEnumerable<T>);
    }

    public IEnumerable<T> GetExportedValues<T>()
    {
      Contract.Ensures(Contract.Result<System.Collections.Generic.IEnumerable<T>>() != null);

      return default(IEnumerable<T>);
    }

    public IEnumerable<Lazy<T, TMetadataView>> GetExports<T, TMetadataView>(string contractName)
    {
      Contract.Ensures(Contract.Result<System.Collections.Generic.IEnumerable<System.Lazy<T, TMetadataView>>>() != null);

      return default(IEnumerable<Lazy<T, TMetadataView>>);
    }

    public IEnumerable<System.ComponentModel.Composition.Primitives.Export> GetExports(System.ComponentModel.Composition.Primitives.ImportDefinition definition)
    {
      return default(IEnumerable<System.ComponentModel.Composition.Primitives.Export>);
    }

    public IEnumerable<System.ComponentModel.Composition.Primitives.Export> GetExports(System.ComponentModel.Composition.Primitives.ImportDefinition definition, AtomicComposition atomicComposition)
    {
      return default(IEnumerable<System.ComponentModel.Composition.Primitives.Export>);
    }

    public IEnumerable<Lazy<T>> GetExports<T>(string contractName)
    {
      Contract.Ensures(Contract.Result<System.Collections.Generic.IEnumerable<System.Lazy<T>>>() != null);

      return default(IEnumerable<Lazy<T>>);
    }

    public IEnumerable<Lazy<T>> GetExports<T>()
    {
      Contract.Ensures(Contract.Result<System.Collections.Generic.IEnumerable<System.Lazy<T>>>() != null);

      return default(IEnumerable<Lazy<T>>);
    }

    public IEnumerable<Lazy<T, TMetadataView>> GetExports<T, TMetadataView>()
    {
      Contract.Ensures(Contract.Result<System.Collections.Generic.IEnumerable<System.Lazy<T, TMetadataView>>>() != null);

      return default(IEnumerable<Lazy<T, TMetadataView>>);
    }

    public IEnumerable<Lazy<Object, Object>> GetExports(Type type, Type metadataViewType, string contractName)
    {
      Contract.Ensures(Contract.Result<System.Collections.Generic.IEnumerable<System.Lazy<System.Object, System.Object>>>() != null);

      return default(IEnumerable<Lazy<Object, Object>>);
    }

    protected abstract IEnumerable<System.ComponentModel.Composition.Primitives.Export> GetExportsCore(System.ComponentModel.Composition.Primitives.ImportDefinition definition, AtomicComposition atomicComposition);

    protected virtual new void OnExportsChanged(ExportsChangeEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnExportsChanging(ExportsChangeEventArgs e)
    {
      Contract.Requires(e != null);
    }

    public bool TryGetExports(System.ComponentModel.Composition.Primitives.ImportDefinition definition, AtomicComposition atomicComposition, out IEnumerable<System.ComponentModel.Composition.Primitives.Export> exports)
    {
      exports = default(IEnumerable<System.ComponentModel.Composition.Primitives.Export>);

      return default(bool);
    }
    #endregion

    #region Events
    public event EventHandler<ExportsChangeEventArgs> ExportsChanged
    {
      add
      {
      }
      remove
      {
      }
    }

    public event EventHandler<ExportsChangeEventArgs> ExportsChanging
    {
      add
      {
      }
      remove
      {
      }
    }
    #endregion
  }
}
