// MIT License

// Copyright (c) 2024 SPIN - Space Innovation

// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:

// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.

// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

namespace SPIN.Contracts.Responses;


/// <summary>
/// Represents a response containing altitude and time information.
/// </summary>
public class GetAltitudeResponse
{
	public Length Altitude { get; set; }


	public DateTime Time { get; set; }

    public Guid Id { get; }

	/// <summary>
	/// Initializes a new instance of the <see cref="GetAltitudeResponse"/> class.
	/// </summary>
	/// <param name="altitude">The altitude value.</param>
	/// <param name="time">The time when the altitude was recorded.</param>
	public GetAltitudeResponse(Length altitude, DateTime time)
	{
		Altitude = altitude;
		Time = time;
        Id = Guid.NewGuid();
	}
}
