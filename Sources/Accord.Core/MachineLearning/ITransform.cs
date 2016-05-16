﻿// Accord Statistics Library
// The Accord.NET Framework
// http://accord-framework.net
//
// Copyright © César Souza, 2009-2015
// cesarsouza at gmail.com
//
//    This library is free software; you can redistribute it and/or
//    modify it under the terms of the GNU Lesser General Public
//    License as published by the Free Software Foundation; either
//    version 2.1 of the License, or (at your option) any later version.
//
//    This library is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
//    Lesser General Public License for more details.
//
//    You should have received a copy of the GNU Lesser General Public
//    License along with this library; if not, write to the Free Software
//    Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA
//

namespace Accord.MachineLearning
{

    /// <summary>
    ///   Common interface for data transformation algorithms. Examples of transformations include
    ///   <see cref="IClassifier{TInput, TClasses}">classifiers</see>, <see cref="IRegression{TInput, TOutputs}">
    ///   regressions</see> and other machine learning techniques.
    /// </summary>
    /// 
    public interface ITransform
    {
        /// <summary>
        ///   Gets the number of inputs accepted by the model.
        /// </summary>
        /// 
        int NumberOfInputs { get; }

        /// <summary>
        ///   Gets the number of outputs generated by the model.
        /// </summary>
        /// 
        int NumberOfOutputs { get; }
    }

    /// <summary>
    ///   Common interface for data transformation algorithms. Examples of transformations include
    ///   <see cref="IClassifier{TInput, TClasses}">classifiers</see>, <see cref="IRegression{TInput, TOutputs}">regressions</see>
    ///   and other machine learning techniques.
    /// </summary>
    /// 
    /// <typeparam name="TInput">The type for the output data that enters in the model. Default is double[].</typeparam>
    /// <typeparam name="TOutput">The type for the input data that exits from the model. Default is double[].</typeparam>
    /// 
    public interface ITransform<in TInput, TOutput> : ITransform
    {
        /// <summary>
        ///   Applies the transformation to an input, producing an associated output.
        /// </summary>
        /// 
        /// <param name="input">The input data to which the transformation should be applied.</param>
        /// 
        /// <returns>The output generated by applying this transformation to the given input.</returns>
        /// 
        TOutput Transform(TInput input);

        /// <summary>
        ///   Applies the transformation to a set of input vectors,
        ///   producing an associated set of output vectors.
        /// </summary>
        /// 
        /// <param name="input">The input data to which
        ///   the transformation should be applied.</param>
        /// 
        /// <returns>The output generated by applying this
        ///   transformation to the given input.</returns>
        /// 
        TOutput[] Transform(TInput[] input);

        /// <summary>
        ///   Applies the transformation to a set of input vectors,
        ///   producing an associated set of output vectors.
        /// </summary>
        /// 
        /// <param name="input">The input data to which
        ///   the transformation should be applied.</param>
        /// <param name="result">The location to where to store the
        ///   result of this transformation.</param>
        /// 
        /// <returns>The output generated by applying this
        ///   transformation to the given input.</returns>
        /// 
        TOutput[] Transform(TInput[] input, TOutput[] result);
    }

    /// <summary>
    ///   Common interface for data transformation algorithms. Examples of transformations include
    ///   <see cref="IClassifier{TInput, TClasses}">classifiers</see>, <see cref="IRegression{TInput, TOutput}">regressions</see>
    ///   and other machine learning techniques.
    /// </summary>
    /// 
    /// <typeparam name="TInput">The type for the output data that enters in the model.</typeparam>
    /// 
    public interface ITransform<TInput> : ITransform<TInput, double[]>
    {
    }

    
}
