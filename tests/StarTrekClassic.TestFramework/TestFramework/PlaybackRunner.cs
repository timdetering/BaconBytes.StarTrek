using System;
using System.Diagnostics;
using System.IO;
using BaconBytes.IO;

namespace StarTrekClassic.TestFramework
{
    /// <summary>
    /// TODO: Playback console input
    /// </summary>
    public sealed class PlaybackRunner : IDisposable
    {
        #region Constructors
        private PlaybackRunner()
        {
            //
            //  Save the original console in and out stream instances.
            //
            _originalInput = Console.In;
            _originalOutput = Console.Out;
            _outputWriter = new StringWriter();

            _consoleOutput = new MultiCastTextWriter();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaybackRunner"/> class with the specified text input.
        /// </summary>
        /// <param name="input"></param>
        public PlaybackRunner(string input) : this(input, false)
        {
        }

        public PlaybackRunner(string input, bool hideOutput) : this()
        {
            Debug.Assert(false == String.IsNullOrEmpty(input));
            _input = new ConsoleInput(input);
            this.Initialize(hideOutput);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaybackRunner"/> class with the specified input stream reader.
        /// </summary>
        /// <param name="input"></param>
        public PlaybackRunner(TextReader input) : this()
        {
            Debug.Assert(null != input && TextReader.Null != input);
            _input = new ConsoleInput(input);
            this.Initialize(false);
        }
        #endregion

        #region Methods
        /// <summary>
        /// Releases all resources used by the object.
        /// </summary>
        /// <remarks>
        /// Calling Dispose allows the resources used by the object to be reallocated for other purposes.
        /// </remarks>
        public void Dispose()
        {
            Debug.Assert(null != _originalInput);
            Console.SetIn(_originalInput);
            _input.Dispose();

            Debug.Assert(null != _originalOutput);
            Console.SetOut(_originalOutput);
            _consoleOutput.Dispose();
        }

        private void Initialize(bool hideOutput)
        {
            Debug.Assert(null != _input);
            Debug.Assert(null != _outputWriter);
            Debug.Assert(null != _originalOutput);
            _input.Writers.Add(_outputWriter);
            if (false == hideOutput)
            {
                _input.Writers.Add(_originalOutput);
            }
            Console.SetIn(_input);

            Debug.Assert(null != _consoleOutput);
            _consoleOutput.Writers.Add(_outputWriter);
            if (false == hideOutput)
            {
                _consoleOutput.Writers.Add(_originalOutput);
            }
            Console.SetOut(_consoleOutput);
        }

        /// <summary>
        /// Returns a string containing the characters written to the current <see cref="Console"/> so far.
        /// </summary>
        /// <returns>
        /// The string containing the characters written to the current <see cref="Console"/>.
        /// </returns>
        /// <remarks>
        /// TODO: Should we provide a GetOutput method instead to be more specific.
        /// </remarks>
        public override string ToString()
        {
            return _outputWriter.ToString();
        }
        #endregion

        #region Fields
        private readonly ConsoleInput _input;
        private readonly TextReader _originalInput;
        private readonly TextWriter _originalOutput;
        private readonly TextWriter _outputWriter;
        private readonly MultiCastTextWriter _consoleOutput;
        #endregion
    }
}
