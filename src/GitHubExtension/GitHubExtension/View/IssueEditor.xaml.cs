﻿// **********************************************************************************
// The MIT License (MIT)
// 
// Copyright (c) 2014 Rob Prouse
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of
// this software and associated documentation files (the "Software"), to deal in
// the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do so,
// subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS
// FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
// COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER
// IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
// CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
// 
// **********************************************************************************

#region Using Directives

using System;
using System.Windows;
using Alteridem.GitHub.Extension.Interfaces;
using Alteridem.GitHub.Extension.ViewModel;
using Alteridem.Tfs.Model;
using Octokit;

#endregion

namespace Alteridem.GitHub.Extension.View
{
    /// <summary>
    /// Interaction logic for EditIssue.xaml
    /// </summary>
    public partial class IssueEditor : IIssueEditor
    {
        private readonly IssueEditorViewModel _gitHubViewModel;

        public IssueEditor()
        {
            InitializeComponent();
            _gitHubViewModel = Factory.Get<IssueEditorViewModel>();
            DataContext = _gitHubViewModel;
        }

        public Window Window { get { return this; } }

        public void SetTfsIssue(TfsWorkItem issue)
        {
            _gitHubViewModel.SetTfsIssue(issue);
            PreviewTab.Focus();
        }

        /// <summary>
        /// Sets the issue to add/edit. If null, we are adding, if set, we edit
        /// </summary>
        /// <param name="issue">The issue.</param>
        public void SetIssue(Octokit.Issue issue)
        {
            _gitHubViewModel.SetIssue(issue);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
