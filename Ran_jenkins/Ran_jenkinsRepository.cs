﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace Ran_jenkins
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the Ran_jenkinsRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("79040f13-bd53-492d-a080-e66dc4e4f4b6")]
    public partial class Ran_jenkinsRepository : RepoGenBaseFolder
    {
        static Ran_jenkinsRepository instance = new Ran_jenkinsRepository();
        Ran_jenkinsRepositoryFolders.RanorexStudioDemoApplicationAppFolder _ranorexstudiodemoapplication;

        /// <summary>
        /// Gets the singleton class instance representing the Ran_jenkinsRepository element repository.
        /// </summary>
        [RepositoryFolder("79040f13-bd53-492d-a080-e66dc4e4f4b6")]
        public static Ran_jenkinsRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public Ran_jenkinsRepository() 
            : base("Ran_jenkinsRepository", "/", null, 0, false, "79040f13-bd53-492d-a080-e66dc4e4f4b6", ".\\RepositoryImages\\Ran_jenkinsRepository79040f13.rximgres")
        {
            _ranorexstudiodemoapplication = new Ran_jenkinsRepositoryFolders.RanorexStudioDemoApplicationAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("79040f13-bd53-492d-a080-e66dc4e4f4b6")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The RanorexStudioDemoApplication folder.
        /// </summary>
        [RepositoryFolder("3eeded0f-92fd-43a9-9fe5-127dd46f50a4")]
        public virtual Ran_jenkinsRepositoryFolders.RanorexStudioDemoApplicationAppFolder RanorexStudioDemoApplication
        {
            get { return _ranorexstudiodemoapplication; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class Ran_jenkinsRepositoryFolders
    {
        /// <summary>
        /// The RanorexStudioDemoApplicationAppFolder folder.
        /// </summary>
        [RepositoryFolder("3eeded0f-92fd-43a9-9fe5-127dd46f50a4")]
        public partial class RanorexStudioDemoApplicationAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _element1114744Info;
            RepoItemInfo _element592262Info;

            /// <summary>
            /// Creates a new RanorexStudioDemoApplication  folder.
            /// </summary>
            public RanorexStudioDemoApplicationAppFolder(RepoGenBaseFolder parentFolder) :
                    base("RanorexStudioDemoApplication", "/form[@title>'Ranorex Studio Demo Appli']", parentFolder, 30000, null, true, "3eeded0f-92fd-43a9-9fe5-127dd46f50a4", "")
            {
                _element1114744Info = new RepoItemInfo(this, "Element1114744", "element[@automationid='1']/?/?/element[@automationid='1114744']", ".//element[@automationid='1114744']", 30000, null, "270f8dba-3ce7-496f-b427-52a895ac019d");
                _element592262Info = new RepoItemInfo(this, "Element592262", "element[@automationid='1']/?/?/element[@automationid='592262']", ".//element[@automationid='592262']", 30000, null, "b8b16790-e539-410a-a61f-15c43c0505ed");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("3eeded0f-92fd-43a9-9fe5-127dd46f50a4")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("3eeded0f-92fd-43a9-9fe5-127dd46f50a4")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Element1114744 item.
            /// </summary>
            [RepositoryItem("270f8dba-3ce7-496f-b427-52a895ac019d")]
            public virtual Ranorex.Unknown Element1114744
            {
                get
                {
                    return _element1114744Info.CreateAdapter<Ranorex.Unknown>(true);
                }
            }

            /// <summary>
            /// The Element1114744 item info.
            /// </summary>
            [RepositoryItemInfo("270f8dba-3ce7-496f-b427-52a895ac019d")]
            public virtual RepoItemInfo Element1114744Info
            {
                get
                {
                    return _element1114744Info;
                }
            }

            /// <summary>
            /// The Element592262 item.
            /// </summary>
            [RepositoryItem("b8b16790-e539-410a-a61f-15c43c0505ed")]
            public virtual Ranorex.Unknown Element592262
            {
                get
                {
                    return _element592262Info.CreateAdapter<Ranorex.Unknown>(true);
                }
            }

            /// <summary>
            /// The Element592262 item info.
            /// </summary>
            [RepositoryItemInfo("b8b16790-e539-410a-a61f-15c43c0505ed")]
            public virtual RepoItemInfo Element592262Info
            {
                get
                {
                    return _element592262Info;
                }
            }
        }

    }
#pragma warning restore 0436
}
