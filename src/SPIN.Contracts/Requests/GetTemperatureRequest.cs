// MIT License
//
// Copyright (c) 2024 SPIN - Space Innovation
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

namespace SPIN.Contracts.Requests;

/// <summary>
/// The <c>GetTemperatureRequest</c> record struct is a request object used to retrieve temperature data within the application.
/// This class is designed to be utilized with the MediatR library for decoupled communication between components.
/// <example>
/// <code>
/// var request = new GetTemperatureRequest
/// {
///     Id = Guid.NewGuid()
/// };
/// var response = await mediatr.Send(request);
/// </code>
/// </example>
/// </summary>
/// <param name="Id">A random Guid generated for each request</param>
public readonly record struct GetTemperatureRequest(Guid Id) : IRequest<GetTemperatureResponse>;