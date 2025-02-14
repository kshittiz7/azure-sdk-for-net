// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Defines a managed rule set. </summary>
    public partial class ManagedRuleSet
    {
        /// <summary> Initializes a new instance of ManagedRuleSet. </summary>
        /// <param name="ruleSetType"> Defines the rule set type to use. </param>
        /// <param name="ruleSetVersion"> Defines the version of the rule set to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleSetType"/> or <paramref name="ruleSetVersion"/> is null. </exception>
        public ManagedRuleSet(string ruleSetType, string ruleSetVersion)
        {
            Argument.AssertNotNull(ruleSetType, nameof(ruleSetType));
            Argument.AssertNotNull(ruleSetVersion, nameof(ruleSetVersion));

            RuleSetType = ruleSetType;
            RuleSetVersion = ruleSetVersion;
            RuleGroupOverrides = new ChangeTrackingList<ManagedRuleGroupOverride>();
        }

        /// <summary> Initializes a new instance of ManagedRuleSet. </summary>
        /// <param name="ruleSetType"> Defines the rule set type to use. </param>
        /// <param name="ruleSetVersion"> Defines the version of the rule set to use. </param>
        /// <param name="ruleGroupOverrides"> Defines the rule group overrides to apply to the rule set. </param>
        internal ManagedRuleSet(string ruleSetType, string ruleSetVersion, IList<ManagedRuleGroupOverride> ruleGroupOverrides)
        {
            RuleSetType = ruleSetType;
            RuleSetVersion = ruleSetVersion;
            RuleGroupOverrides = ruleGroupOverrides;
        }

        /// <summary> Defines the rule set type to use. </summary>
        public string RuleSetType { get; set; }
        /// <summary> Defines the version of the rule set to use. </summary>
        public string RuleSetVersion { get; set; }
        /// <summary> Defines the rule group overrides to apply to the rule set. </summary>
        public IList<ManagedRuleGroupOverride> RuleGroupOverrides { get; }
    }
}
