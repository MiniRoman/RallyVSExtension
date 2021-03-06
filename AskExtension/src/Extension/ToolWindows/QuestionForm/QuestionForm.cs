﻿//------------------------------------------------------------------------------
// <copyright file="QuestionForm.cs" company="Company">
//     Copyright (c) Company.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

namespace AskExtension
{
    using System.Runtime.InteropServices;
    using Microsoft.VisualStudio.Shell;

    /// <summary>
    /// This class implements the tool window exposed by this package and hosts a user control.
    /// </summary>
    /// <remarks>
    /// In Visual Studio tool windows are composed of a frame (implemented by the shell) and a pane,
    /// usually implemented by the package implementer.
    /// <para>
    /// This class derives from the ToolWindowPane class provided from the MPF in order to use its
    /// implementation of the IVsUIElementPane interface.
    /// </para>
    /// </remarks>
    [Guid("c5d31c16-bebf-46fd-a204-8f5da92090ac")]
    public class QuestionForm : ToolWindowPane
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="QuestionForm"/> class.
        /// </summary>
        public QuestionForm() : base(null)
        {

            this.Caption = "QuestionForm";

            // This is the user control hosted by the tool window; Note that, even if this class implements IDisposable,
            // we are not calling Dispose on this object. This is because ToolWindowPane calls Dispose on
            // the object returned by the Content property.
            this.Content = new QuestionFormControl();
        }

        public void SetContent(string code)
        {
            var questionFormControl = this.Content as QuestionFormControl;
            questionFormControl?.UpdateContent(code);
        }
    }
}
