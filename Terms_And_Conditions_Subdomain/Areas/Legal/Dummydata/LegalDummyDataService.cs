using YourNamespace.Areas.Legal.Models;
using YourNamespace.Areas.Legal.ViewModels;

namespace YourNamespace.Areas.Legal.DummyData
{
    public static class LegalDummyDataService
    {
        public static LegalPageViewModel GetTermsAndConditions()
        {
            return new LegalPageViewModel
            {
                PageTitle = "Terms and conditions (English)",
                Version = "1.0",
                LastUpdated = "August 7th, 2026",
                Sections = new List<LegalSection>
                {
                    new LegalSection
                    {
                        SectionNumber = 1,
                        Title = "INTRODUCTION",
                        NavLabel = "Introduction",
                        AnchorId = "introduction",
                        Clauses = new List<LegalClause>
                        {
                            new LegalClause { Number = "1.1", Text = "These Terms and Conditions (\"Terms\") constitute a legally binding agreement between LIVELY AFRICA (\"Company\", \"we\", \"us\", or \"our\") and any person who accesses or uses the Company's services (\"User\", \"you\", or \"your\"), including but not limited to our e-commerce and streaming platform, website, mobile applications, and all related services (collectively referred to as the \"Platform\")." },
                            new LegalClause { Number = "1.2", Text = "These Terms govern your access to the use of the Platform and all services made available through it." },
                            new LegalClause { Number = "1.3", Text = "By accessing, browsing, registering on, or otherwise using the Platform, you acknowledge that you have read, understood, and agreed to be bound by these Terms, as may be amended from time to time." },
                            new LegalClause { Number = "1.4", Text = "If you do not agree to these Terms, you must immediately cease and refrain from accessing or using the Platform." }
                        }
                    },
                    new LegalSection
                    {
                        SectionNumber = 2,
                        Title = "ELIGIBILITY",
                        NavLabel = "Eligibility",
                        AnchorId = "eligibility",
                        Clauses = new List<LegalClause>
                        {
                            new LegalClause { Number = "2.1", Text = "Access to the use of the Platform is limited to individuals who are at least <strong>eighteen (18) years of age.</strong> Where a user is below the age of eighteen (18) years, such access and use shall be permitted only with the <strong>consent and supervision of a parent or legal guardian</strong>, who shall be responsible for the user's compliance with these Terms." },
                            new LegalClause
                            {
                                Number = "2.2",
                                Text = "By accessing or using the Platform, you represent and warrant that:",
                                SubClauses = new List<LegalSubClause>
                                {
                                    new LegalSubClause { Label = "a.", Text = "you possess the legal capacity and authority to enter into a <strong>legally binding agreement</strong> under applicable laws; and" },
                                    new LegalSubClause { Label = "b.", Text = "where applicable, you have obtained the requisite consent from a parent or legal guardian." }
                                }
                            },
                            new LegalClause { Number = "2.3", Text = "<strong>LIVELY AFRICA</strong> reserves the right to <strong>restrict, suspend, or terminate access</strong> to the Platform where it reasonably believes that a user does not meet the eligibility requirements set out in this Clause." }
                        }
                    },
                    new LegalSection
                    {
                        SectionNumber = 3,
                        Title = "NATURE OF THE MARKETPLACE",
                        NavLabel = "Nature of the Marketplace",
                        AnchorId = "nature-of-the-marketplace",
                        Clauses = new List<LegalClause>
                        {
                            new LegalClause { Number = "3.1", Text = "The Platform operates as an online \"venue\" and intermediary marketplace. We provide the infrastructure for third-party sellers (\"Sellers\") to list products and for buyers (\"Buyers\") to purchase them." },
                            new LegalClause { Number = "3.2", Text = "Non-Party Status: You explicitly acknowledge and agree that LIVELY AFRICA is not a party to the transaction between the Buyer and the Seller. We do not represent either the Buyer or the Seller in specific transactions." },
                            new LegalClause { Number = "3.3", Text = "The contract for the sale and purchase of any product is strictly between the Buyer and the Seller. Consequently, LIVELY AFRICA shall have no liability for any issues arising from the quality, safety, legality, or delivery of products sold by third parties." }
                        }
                    },
                    new LegalSection
                    {
                        SectionNumber = 4,
                        Title = "USER ACCOUNT",
                        NavLabel = "User Account",
                        AnchorId = "user-account",
                        Clauses = new List<LegalClause>
                        {
                            new LegalClause { Number = "4.1", Text = "In order to access certain features or services on the Platform, you may be required to register for and maintain a user account." },
                            new LegalClause
                            {
                                Number = "4.2",
                                Text = "In creating and maintaining your account, you agree to:",
                                SubClauses = new List<LegalSubClause>
                                {
                                    new LegalSubClause { Label = "a.", Text = "provide accurate, current, and complete information as may be required during the registration process and to promptly update such information where necessary;" },
                                    new LegalSubClause { Label = "b.", Text = "maintain the confidentiality and security of your login credentials, including your username and password, and not disclose them to any third party; and" },
                                    new LegalSubClause { Label = "c.", Text = "promptly notify LIVELY AFRICA of any actual or suspected unauthorized access to or use of your account." }
                                }
                            },
                            new LegalClause { Number = "4.3", Text = "You shall be solely responsible for all activities conducted through your account, whether authorized or unauthorized." },
                            new LegalClause { Number = "4.4", Text = "For all Complaints the app interface will automatically generate a unique \"Complaint ID\" for every user report or complaint." },
                            new LegalClause { Number = "4.5", Text = "To the fullest extent permitted by applicable law, LIVELY AFRICA shall not be liable for any loss, damage, or liability arising from or in connection with any unauthorized access to or use of your account, except where such loss arises directly from LIVELY AFRICA's proven negligence or willful misconduct." },
                            new LegalClause { Number = "4.6", Text = "Identity Verification and KYC: To maintain a secure marketplace and comply with Anti-Money Laundering (AML) regulations, the Company employs a multi-layered verification process. Users acknowledge that the submission of valid government-issued identification (such as a NIN, BVN, or International Passport) and, where applicable, business registration documents, is a mandatory condition <strong>for account activation, withdrawing transaction funds from escrow, and participating in live-streaming or e-commerce activities.</strong>" }
                        }
                    },
                    new LegalSection
                    {
                        SectionNumber = 5,
                        Title = "SERVICES PROVIDED",
                        NavLabel = "Services Provided",
                        AnchorId = "services-provided",
                        Clauses = new List<LegalClause>
                        {
                            new LegalClause
                            {
                                Number = "5.1",
                                Text = "The Platform provides a range of digital services, which may include, without limitation:",
                                SubClauses = new List<LegalSubClause>
                                {
                                    new LegalSubClause { Label = "a.", Text = "E-commerce services, comprising the listing, marketing, sale, and delivery of physical goods and/or digital products;" },
                                    new LegalSubClause { Label = "b.", Text = "Streaming services, enabling access to audio-visual content, whether live-streamed or made available on-demand; and" },
                                    new LegalSubClause { Label = "c.", Text = "Subscription-based and pay-per-view services, granting users access to premium content subject to applicable fees and payment terms." }
                                }
                            },
                            new LegalClause { Number = "5.2", Text = "LIVELY AFRICA reserves the right, at its sole discretion and from time to time, to modify, suspend, or discontinue any aspect of the services provided on the Platform, with or without prior notice, subject to applicable law." }
                        }
                    },

                    new LegalSection
                    {
                        SectionNumber = 6,
                        Title = "ORDERS AND PAYMENTS",
                        NavLabel = "Orders and Payment",
                        AnchorId = "orders-and-payments",
                        Clauses = new List<LegalClause>
                        {
                            new LegalClause { Number = "6.1", Text = "All orders placed through the Platform shall constitute an offer by the User to purchase the relevant goods or services and shall be subject to acceptance by LIVELY AFRICA. LIVELY AFRICA reserves the right, at its sole discretion, to accept or reject any order." },
                            new LegalClause { Number = "6.2", Text = "Unless otherwise expressly stated, all prices displayed on the Platform are denominated in <strong>Nigerian Naira (&#8358;)</strong> and are subject to change without prior notice." },
                            new LegalClause { Number = "6.3", Text = "Payments for orders shall be processed through secure third-party payment service providers. By making a payment, you agree to comply with the terms and conditions of such third-party providers." },
                            new LegalClause
                            {
                                Number = "6.4",
                                Text = "LIVELY AFRICA reserves the right, at its sole discretion, to:",
                                SubClauses = new List<LegalSubClause>
                                {
                                    new LegalSubClause { Label = "a.", Text = "Refuse or cancel any order, including but not limited to instances of suspected fraud, unauthorized transactions, or unavailability of products or services;" },
                                    new LegalSubClause { Label = "b.", Text = "Correct any errors or inaccuracies in pricing, product descriptions, or other information on the Platform, whether or not the order has been confirmed; and" },
                                    new LegalSubClause { Label = "c.", Text = "Impose limits on the quantity of items that may be purchased by a User." },
                                    new LegalSubClause { Label = "d.", Text = "All displayed prices on the platform will be inclusive of VAT. We will integrate major local payment gateways (e.g., Paystack, Flutterwave)." },
                                    new LegalSubClause { Label = "e.", Text = "Crucially, the platform will hold all transaction funds in escrow until the buyer confirms physical delivery of the product." }
                                }
                            }
                        }
                    },
                    new LegalSection
                    {
                        SectionNumber = 7,
                        Title = "RETURNS & REFUNDS",
                        NavLabel = "Returns and Refunds",
                        AnchorId = "returns-and-refunds",
                        Clauses = new List<LegalClause>
                        {
                            new LegalClause { Number = "7.1", Text = "<strong>Return Window:</strong> Customers are entitled to a <strong>seven (7) day \"cooling-off\" period</strong> for returns, commencing from the date of <strong>physical delivery</strong> of the purchased item." },
                            new LegalClause { Number = "7.2", Text = "<strong>Live Auction Purchases:</strong> For items acquired through the Platform's <strong>live auction feature</strong>, the standard <strong>seven (7) day return policy</strong> shall apply however in the event of a return or dispute regarding a live auction item, the <strong>condition of the item as presented during the live auction video</strong> shall be considered a primary factor in determining the outcome." },
                            new LegalClause { Number = "7.3", Text = "All returns must comply with LIVELY AFRICA's <strong>return procedures</strong> as outlined on the Platform. LIVELY AFRICA reserves the right to <strong>deny returns</strong> that do not meet these requirements." }
                        }
                    },
                    new LegalSection
                    {
                        SectionNumber = 8,
                        Title = "SUBSCRIPTIONS AND STREAMING",
                        NavLabel = "Subscription and Streaming",
                        AnchorId = "subscriptions-and-streaming",
                        Clauses = new List<LegalClause>
                        {
                            new LegalClause { Number = "8.1", Text = "<strong>Subscription Access:</strong> Access to certain content available on the Platform may be subject to the payment of subscription fees or other applicable charges." },
                            new LegalClause { Number = "8.2", Text = "<strong>Billing Cycles:</strong> Subscription plans shall be billed on a recurring basis, which may be monthly, annually, or at such other intervals as specified at the point of subscription." },
                            new LegalClause { Number = "8.3", Text = "<strong>Automatic Renewal:</strong> Unless otherwise stated, subscriptions shall automatically renew at the end of each billing cycle under the same terms and conditions, unless cancelled by the User in accordance with the Company's cancellation procedures prior to the renewal date." },
                            new LegalClause { Number = "8.4", Text = "<strong>Fee Modifications:</strong> The Company reserves the right to review and modify subscription fees or billing structures from time to time. Any such changes shall be communicated to Users in advance and shall take effect at the next applicable billing cycle." },
                            new LegalClause { Number = "8.5", Text = "<strong>Nature of Streaming Content (License vs. Sale):</strong> All streaming content made available on the Platform is licensed and not sold to the User. Such content is provided strictly for personal, non-commercial use, and the User shall not reproduce, distribute, publicly perform, or otherwise exploit such content without the prior written consent of the Company or the relevant rights holder." },
                            new LegalClause { Number = "8.6", Text = "<strong>Technical Compatibility &amp; Streaming Quality:</strong> The Company facilitates the electronic delivery of streaming transmissions but does not warrant that digital files or streams will be continuously compatible with all User hardware, operating systems, or third-party software. <strong>You acknowledge that access quality, resolution, and performance are subject to external factors including your internet service provider's bandwidth and geographic location.</strong> The Company shall not be liable for any buffering, latency, or failure of the stream due to such external factors. Access quality and performance may vary based on the User's internet bandwidth and device specifications." },
                            new LegalClause { Number = "8.7", Text = "<strong>Seller/Streamer Warranties on Digital Rights:</strong> In respect of any digital products, premium content, or streaming access offered for a fee, the Seller (or Content Creator) warrants and represents that they possess the absolute legal title, necessary Intellectual Property rights, and all required third-party authorizations to supply, broadcast, or sell said content." },
                            new LegalClause { Number = "8.8", Text = "<strong>Regulatory Compliance (ARCON &amp; Advertising):</strong> Every streamer/seller is responsible for obtaining the necessary vetting from the Advertising Regulatory Council of Nigeria (ARCON) for live-streamed advertisements or promotional content. The Company reserves the right to request documented proof of such vetting and may suspend or remove any content that fails to provide evidence of regulatory approval." }
                        }
                    },
                    new LegalSection
                    {
                        SectionNumber = 9,
                        Title = "USER-GENERATED CONTENT & LICENSING",
                        NavLabel = "User-generated content & licensing",
                        AnchorId = "user-generated-content-licensing",
                        Clauses = new List<LegalClause>
                        {
                            new LegalClause { Number = "9.1", Text = "<strong>Grant of License:</strong> By uploading, posting, or streaming content on the Platform (\"User Content\"), you grant LIVELY AFRICA a worldwide, irrevocable, non-exclusive, royalty-free, and fully sub-licensable license to use, reproduce, modify, adapt, publish, translate, and distribute your content across our marketing channels and any existing or future media." },
                            new LegalClause { Number = "9.2", Text = "<strong>Waiver of Moral Rights:</strong> To the maximum extent permitted by the laws of the Federal Republic of Nigeria, you hereby irrevocably waive all \"moral rights\" or other rights with respect to the attribution of authorship or integrity of materials regarding User Content." },
                            new LegalClause { Number = "9.3", Text = "<strong>Monetization:</strong> You acknowledge that LIVELY AFRICA may generate revenue or increase goodwill from your use of the Services (including through advertising or sponsorships) and, except as specifically permitted in a separate written agreement, you shall have no right to share in such revenue." }
                        }
                    },
                    new LegalSection
                    {
                        SectionNumber = 10,
                        Title = "DELIVERY AND RETURNS (E-COMMERCE)",
                        NavLabel = "Delivery and Returns (E-Commerce)",
                        AnchorId = "delivery-and-returns-ecommerce",
                        Clauses = new List<LegalClause>
                        {
                            new LegalClause { Number = "10.1", Text = "Any delivery timelines provided by LIVELY AFRICA are <strong>estimates only</strong> and are subject to change. While the Company shall use reasonable efforts to meet indicated delivery dates, it does not guarantee delivery within such timeframes and shall not be liable for delays arising from factors beyond its reasonable control." },
                            new LegalClause { Number = "10.2", Text = "All returns, exchanges, and refunds shall be governed by LIVELY AFRICA's <strong>Return and Refund Policy</strong>, as may be updated from time to time, and shall be subject to the applicable provisions of the Federal Competition and Consumer Protection Act 2018." },
                            new LegalClause { Number = "10.3", Text = "The \"Risk of Loss\" passes to the consumer only upon confirmed physical delivery to the buyer's specified address." }
                        }
                    },

                    new LegalSection
                    {
                        SectionNumber = 11,
                        Title = "INTELLECTUAL PROPERTY",
                        NavLabel = "Intellectual Property",
                        AnchorId = "intellectual-property",
                        Clauses = new List<LegalClause>
                        {
                            new LegalClause { Number = "11.1", Text = "All intellectual property rights in and to the Platform and its contents, including but not limited to <strong>videos, audio materials, images, software, text, graphics, logos, trademarks, and other proprietary materials</strong> (collectively referred to as the \"Content\"), are and shall remain the exclusive property of the Sellers and Creators as they retain the Intellectual Property (IP) ownership of their live streams. However, Lively Africa requires a perpetual, worldwide, royalty-free, sublicensable license to use recorded streams for platform promotion, marketing, and the training of our AI models. <strong>LIVELY AFRICA</strong> and/or its licensors are protected by applicable intellectual property laws." },
                            new LegalClause { Number = "11.2", Text = "Subject to these Terms, LIVELY AFRICA grants the User a limited, non-exclusive, non-transferable, and revocable right to access and use the Content solely for <strong>personal, non-commercial purposes.</strong>" },
                            new LegalClause
                            {
                                Number = "11.3",
                                Text = "The User shall not, without the prior written consent of LIVELY AFRICA or the relevant rights holder:",
                                SubClauses = new List<LegalSubClause>
                                {
                                    new LegalSubClause { Label = "a.", Text = "copy, reproduce, distribute, transmit, display, perform, or otherwise exploit any Content;" },
                                    new LegalSubClause { Label = "b.", Text = "modify, adapt, translate, or create derivative works from any Content; or" },
                                    new LegalSubClause { Label = "c.", Text = "use any Content for commercial or unauthorized purposes." }
                                }
                            },
                            new LegalClause { Number = "11.4", Text = "Any unauthorized use of the Content shall constitute a violation of LIVELY AFRICA's intellectual property rights and may result in legal action." },
                            new LegalClause { Number = "11.5", Text = "Recording Retention: Live streams are recorded and stored for a rolling retention period of twelve (12) months for purposes of quality control, dispute resolution, and AI model training, after which they shall be securely deleted or pseudonymized." }
                        }
                    },
                    new LegalSection
                    {
                        SectionNumber = 12,
                        Title = "USER CONDUCT",
                        NavLabel = "User Conduct",
                        AnchorId = "user-conduct",
                        Clauses = new List<LegalClause>
                        {
                            new LegalClause { Number = "12.1", Text = "By accessing and using the Platform, you agree to act in a lawful, ethical, and responsible manner at all times." },
                            new LegalClause { Number = "12.2", Text = "You shall not, and shall not attempt to, directly or indirectly:" },
                            new LegalClause
                            {
                                Number = "",
                                Text = "",
                                SubClauses = new List<LegalSubClause>
                                {
                                    new LegalSubClause { Label = "a.", Text = "use the Platform for any purpose that is <strong>illegal, fraudulent, or otherwise prohibited by applicable law;</strong>" },
                                    new LegalSubClause { Label = "b.", Text = "interfere with, disrupt, or compromise the security, integrity, or proper functioning of the Platform or any associated systems, networks, or servers;" },
                                    new LegalSubClause { Label = "c.", Text = "upload, transmit, or distribute any content that is <strong>harmful, malicious, offensive, defamatory, infringing</strong>, insulting to Nigerian culture, inciting or obscene or <strong>otherwise objectionable</strong> as required by the NITDA Code of Practice;" },
                                    new LegalSubClause { Label = "d.", Text = "attempt to gain <strong>unauthorized access</strong> to any accounts, systems, data, or networks connected to the Platform; or" },
                                    new LegalSubClause { Label = "e.", Text = "engage in any activity that could <strong>damage, disable, overburden, or impair the Platform</strong> or impede other users' access or use." },
                                    new LegalSubClause { Label = "f.", Text = "users engaging in paid or promotional live streams must utilize the Platform's mandatory \"#Ad\" or \"Sponsored\" labels. Failure to disclose a commercial relationship in a prominent manner is a violation of these Terms and may result in immediate stream termination." }
                                }
                            },
                            new LegalClause { Number = "12.3", Text = "<strong>LIVELY AFRICA</strong> reserves the right, at its sole discretion, to <strong>suspend, restrict, or terminate access</strong> to the Platform for any User who violates this Clause, without prior notice and without liability to the User." }
                        }
                    },
                    new LegalSection
                    {
                        SectionNumber = 13,
                        Title = "PRIVACY",
                        NavLabel = "Privacy",
                        AnchorId = "privacy",
                        Clauses = new List<LegalClause>
                        {
                            new LegalClause { Number = "13.1", Text = "The collection, processing, and use of your personal data in connection with your access to and use of the Platform are governed by LIVELY AFRICA's <strong>Privacy Policy</strong>, which forms an integral part of these Terms." },
                            new LegalClause { Number = "13.2", Text = "By using the Platform, you acknowledge that you have read, understood, and consent to the practices described in the Privacy Policy, including the collection, storage, and processing of your personal data in compliance with the provisions of the Nigeria Data Protection Act 2023 and other applicable data protection laws." },
                            new LegalClause { Number = "13.3", Text = "<strong>LIVELY AFRICA</strong> is committed to protecting your privacy and shall implement appropriate technical and organizational measures to safeguard your personal data." }
                        }
                    },
                    new LegalSection
                    {
                        SectionNumber = 14,
                        Title = "DATA PRIVACY & PROTECTION",
                        NavLabel = "Data privacy & Protection",
                        AnchorId = "data-privacy-protection",
                        Clauses = new List<LegalClause>
                        {
                            new LegalClause { Number = "14.1", Text = "All personal data collected through the Platform is processed in accordance with the Nigeria Data Protection Act 2023, General Application and Implementation Directive (GAID 2025) and our Privacy Policy." },
                            new LegalClause { Number = "14.2", Text = "By using the Platform, you consent to the collection, use, and transfer of your data as outlined in our Privacy and Cookie Notice. You acknowledge that Sellers are independently responsible for any misuse of Buyer data once shared for the purpose of fulfilling an order and the Company shall bear no liability for such third-party breaches." },
                            new LegalClause { Number = "14.3", Text = "Automated Profiling and Smart Recommendations: The Platform utilizes automated processing and profiling to generate \"Smart Recommendations,\" rank content, and power Virtual Hosts. In accordance with the Nigeria Data Protection Laws, Users have the right to opt-out of such automated profiling through their account settings. You acknowledge that opting out of profiling may significantly limit the personalization of your user experience and the relevance of content discovery on the Platform."


                            }
                        }
                    },


                    new LegalSection
                    {
                        SectionNumber = 15,
                        Title = "THIRD-PARTY SERVICES",
                        NavLabel = "Third-party Services",
                        AnchorId = "third-party-services",
                        Clauses = new List<LegalClause>
                        {
                            new LegalClause { Number = "15.1", Text = "The Platform may integrate with or provide access to third-party services, including but not limited to <strong>payment gateways, content providers, or other external service providers</strong> (\"Third-Party Services\")." },
                            new LegalClause { Number = "15.2", Text = "<strong>LIVELY AFRICA</strong> does not control, endorse, or assume any responsibility for the availability, accuracy, legality, or content of Third-Party Services." },
                            new LegalClause { Number = "15.3", Text = "Your use of any Third-Party Services is subject to the applicable terms, policies, and practices of such third parties. <strong>LIVELY AFRICA</strong> shall not be liable for any loss, damage, or liability arising from your interaction with, or reliance on, Third-Party Services." },
                            new LegalClause { Number = "15.4", Text = "Users are advised to review the terms and privacy policies of any Third-Party Services they access via the Platform before engaging with such services." }
                        }
                    },
                    new LegalSection
                    {
                        SectionNumber = 16,
                        Title = "LIMITATION OF LIABILITY",
                        NavLabel = "Limitation of Liability",
                        AnchorId = "limitation-of-liability",
                        Clauses = new List<LegalClause>
                        {
                            new LegalClause
                            {
                                Number = "16.1",
                                Text = "To the maximum extent permitted by applicable law, <strong>LIVELY AFRICA</strong>, its affiliates, officers, directors, employees, and agents shall <strong>not be liable</strong> for any direct, indirect, incidental, consequential, or special losses or damages, including but not limited to:",
                                SubClauses = new List<LegalSubClause>
                                {
                                    new LegalSubClause { Label = "a.", Text = "loss of profits, revenue, or business opportunities;" },
                                    new LegalSubClause { Label = "b.", Text = "loss, corruption, or compromise of data;" },
                                    new LegalSubClause { Label = "c.", Text = "service interruptions, system failures, or technical errors; or" },
                                    new LegalSubClause { Label = "d.", Text = "any other loss or damage arising from your access to or use of the Platform." }
                                }
                            },
                            new LegalClause { Number = "16.2", Text = "The Platform, including all content, features, and services provided therein, is made available on an <strong>\"as is\" and \"as available\" basis</strong>, without warranties of any kind, whether express, implied, statutory, or otherwise, including but not limited to warranties of merchantability, fitness for a particular purpose, or non-infringement." },
                            new LegalClause { Number = "16.3", Text = "Nothing in this Clause shall exclude or limit <strong>LIVELY AFRICA's</strong> liability to the extent such exclusion or limitation is <strong>prohibited by law.</strong>" },
                            new LegalClause { Number = "16.4", Text = "Liability for service interruptions during a live stream that result in a lost bid or failed transaction will be strictly limited to the value of the bid or transaction amount involved. <strong>LIVELY AFRICA</strong> disclaims liability for any indirect or consequential loss." }
                        }
                    },
                    new LegalSection
                    {
                        SectionNumber = 17,
                        Title = "DISCLAIMER",
                        NavLabel = "Disclaimer",
                        AnchorId = "disclaimer",
                        Clauses = new List<LegalClause>
                        {
                            new LegalClause { Number = "17.1", Text = "<strong>LIVELY AFRICA</strong> makes no representations or warranties regarding the Platform, including but not limited to the accuracy, reliability, availability, or suitability of the services and content provided." },
                            new LegalClause
                            {
                                Number = "17.2",
                                Text = "Without limiting the generality of the foregoing, <strong>LIVELY AFRICA</strong> does not guarantee that:",
                                SubClauses = new List<LegalSubClause>
                                {
                                    new LegalSubClause { Label = "a.", Text = "the Platform will be <strong>uninterrupted, secure, or free from errors;</strong>" },
                                    new LegalSubClause { Label = "b.", Text = "the content available on the Platform will <strong>meet your specific expectations, requirements or needs;</strong> or" },
                                    new LegalSubClause { Label = "c.", Text = "all defects, bugs, or technical issues will be identified or corrected in a timely manner." }
                                }
                            },
                            new LegalClause { Number = "17.3", Text = "Users acknowledge and agree that their use of the Platform is <strong>at their own risk</strong>, and <strong>LIVELY AFRICA</strong> shall not be liable for any loss or damage resulting from reliance on, or use of, the Platform or its content, except to the extent prohibited by applicable law." }
                        }
                    },
                    new LegalSection
                    {
                        SectionNumber = 18,
                        Title = "SUSPENSION AND TERMINATION",
                        NavLabel = "Suspension and Termination",
                        AnchorId = "suspension-and-termination",
                        Clauses = new List<LegalClause>
                        {
                            new LegalClause
                            {
                                Number = "18.1",
                                Text = "<strong>LIVELY AFRICA</strong> reserves the right, at its sole discretion, to <strong>suspend, restrict, or terminate your access</strong> to the Platform, in whole or in part, in the event of:",
                                SubClauses = new List<LegalSubClause>
                                {
                                    new LegalSubClause { Label = "A:", Text = "a severe violation." },
                                    new LegalSubClause { Label = "B:", Text = "Report of unlawful content or content that violates our policies within a 24-hour timeframe." },
                                    new LegalSubClause { Label = "C:", Text = "Any breach of any of the terms in this terms &amp; condition contract including but not limited to engagement in unlawful, fraudulent, or prohibited activities and or any other reason within the breach of this contract with or without notice." }
                                }
                            },
                            new LegalClause { Number = "18.2", Text = "Upon termination or suspension, all rights granted to you under these Terms shall <strong>immediately cease</strong>, and you must promptly discontinue all use of the Platform and its services." },
                            new LegalClause { Number = "18.3", Text = "Real-Time Moderation: The Company utilizes AI-native fraud detection and monitoring systems to conduct real-time moderation. We reserve the right to terminate any live stream instantly and without prior notice if a severe violation of these Terms or our Community Standards is detected." }
                        }
                    },
                    new LegalSection
                    {
                        SectionNumber = 19,
                        Title = "LIMITATION OF LIABILITY",
                        NavLabel = "Limitation of Liability",
                        AnchorId = "limitation-of-liability-2",
                        Clauses = new List<LegalClause>
                        {
                            new LegalClause { Number = "19.1", Text = "<strong>Statutory Carve-out:</strong> Nothing in these Terms shall exclude or limit the Company's liability for death or personal injury resulting from its proven negligence, fraud, or any other liability that cannot be excluded or limited under the laws of the Federal Republic of Nigeria (including the Federal Competition and Consumer Protection Act)." },
                            new LegalClause { Number = "19.2", Text = "<strong>General Limitation:</strong> Subject to Section 15.1, the Company shall not be liable to you for any indirect, incidental, special, or consequential damages, including but not limited to loss of profits, data, revenue, or goodwill arising from your use of the e-commerce or streaming functionalities, even if the Company has been advised of the possibility of such damages." },
                            new LegalClause { Number = "19.3", Text = "<strong>Third-Party Content:</strong> The Company shall not be held liable for the conduct of any User or for any User Content or third-party products made available through the Platform. Your interaction with other Users and your reliance on any content is at your own risk." }
                        }
                    },
                    new LegalSection
                    {
                        SectionNumber = 20,
                        Title = "INDEMNITY",
                        NavLabel = "Indemnity",
                        AnchorId = "indemnity",
                        Clauses = new List<LegalClause>
                        {
                            new LegalClause
                            {
                                Number = "20.1",
                                Text = "You agree to <strong>indemnify, defend, and hold harmless LIVELY AFRICA, its affiliates, officers, directors, employees, and agents</strong> from and against any and all claims, liabilities, damages, losses, costs, or expenses (including legal fees) arising out of or in connection with:",
                                SubClauses = new List<LegalSubClause>
                                {
                                    new LegalSubClause { Label = "a.", Text = "Your use of the Platform;" },
                                    new LegalSubClause { Label = "b.", Text = "Your breach of these Terms; or" },
                                    new LegalSubClause { Label = "c.", Text = "Any violation of applicable laws or regulations." }
                                }
                            },
                            new LegalClause { Number = "20.2", Text = "This indemnity obligation shall survive the termination of your access to the Platform." }
                        }
                    },
                    new LegalSection
                    {
                        SectionNumber = 21,
                        Title = "FORCE MAJEURE",
                        NavLabel = "Force Majeure",
                        AnchorId = "force-majeure",
                        Clauses = new List<LegalClause>
                        {
                            new LegalClause
                            {
                                Number = "21.1",
                                Text = "<strong>LIVELY AFRICA</strong> shall not be liable for any failure or delay in performing its obligations under these Terms where such failure or delay results from circumstances <strong>beyond its reasonable control</strong>, including, without limitation:",
                                SubClauses = new List<LegalSubClause>
                                {
                                    new LegalSubClause { Label = "a.", Text = "natural disasters or acts of God;" },
                                    new LegalSubClause { Label = "b.", Text = "internet, power, or telecommunications failures;" },
                                    new LegalSubClause { Label = "c.", Text = "governmental actions, regulations, or restrictions; or" },
                                    new LegalSubClause { Label = "d.", Text = "other events or circumstances that are unforeseeable or beyond LIVELY AFRICA's control, which is not limited to national grid failures, telecommunications infrastructure collapse, or government-mandated internet shutdowns." }
                                }
                            },
                            new LegalClause { Number = "21.2", Text = "In such circumstances, LIVELY AFRICA shall be entitled to <strong>suspend or delay performance</strong> without liability for any resulting losses or damages." }
                        }
                    },
                    new LegalSection
                    {
                        SectionNumber = 22,
                        Title = "GOVERNING LAW AND DISPUTE RESOLUTION",
                        NavLabel = "Governing law and Dispute resolution",
                        AnchorId = "governing-law",
                        Clauses = new List<LegalClause>
                        {
                            new LegalClause { Number = "22.1", Text = "These Terms shall be governed by and construed in accordance with the laws of the <strong>Federal Republic of Nigeria.</strong>" },
                            new LegalClause { Number = "22.2", Text = "Any dispute, controversy, or claim arising out of or relating to these Terms, including their validity, interpretation, or enforcement, shall first be <strong>attempted to be resolved amicably</strong> through a mandatory, platform-operated internal mediation and resolution process." },
                            new LegalClause { Number = "22.3", Text = "If a dispute cannot be resolved through internal mediation within thirty (30) days, and the value of the dispute exceeds the Company's internal mediation threshold, it shall be referred to and finally resolved by arbitration at the <strong>Lagos Court of Arbitration (LCA)</strong> in accordance with its rules." }
                        }
                    },
                    new LegalSection
                    {
                        SectionNumber = 23,
                        Title = "AMENDMENTS",
                        NavLabel = "Amendment",
                        AnchorId = "amendments",
                        Clauses = new List<LegalClause>
                        {
                            new LegalClause { Number = "23.1", Text = "LIVELY AFRICA reserves the right to <strong>update, modify, or amend</strong> these Terms at any time." },
                            new LegalClause { Number = "23.2", Text = "Any changes will be effective immediately upon posting the updated Terms on the Platform, with the revised <strong>\"Last Updated\"</strong> date clearly indicated." },
                            new LegalClause { Number = "23.3", Text = "Continued use of the Platform after such updates constitutes your <strong>acceptance of the modified Terms.</strong>" }
                        }
                    },
                    new LegalSection
                    {
                        SectionNumber = 24,
                        Title = "CONTACT INFORMATION",
                        NavLabel = "Contact Information",
                        AnchorId = "contact-information",
                        Clauses = new List<LegalClause>
                        {
                            new LegalClause { Number = "", Text = "For any inquiries, complaints, or to exercise your rights under these Terms, please contact the Company at:" },
                            new LegalClause { Number = "", Text = "<strong>LIVELY AFRICA</strong><br/>Address: Ibukun House, Ademola Adetokunbo, V.I Lagos.<br/>Email: ___________________________<br/>Phone: ___________________________" }
                        }
                    },
                    new LegalSection
                    {
                        SectionNumber = 25,
                        Title = "ACCEPTANCE",
                        NavLabel = "Acceptance",
                        AnchorId = "acceptance",
                        Clauses = new List<LegalClause>
                        {
                            new LegalClause { Number = "", Text = "By accessing or using the Platform, you acknowledge that you have <strong>read, understood, and agreed</strong> to be bound by these Terms and Conditions, including any amendments or updates posted from time to time." }
                        }
                    }
                },

            };

            }


        public static LegalPageViewModel GetPrivacyPolicy()
        {
            return new LegalPageViewModel
            {
                PageTitle = "PRIVACY POLICY (English)",
                Version = "1.0",
                LastUpdated = "August 7th, 2026",
                Sections = new List<LegalSection>
        {
            new LegalSection
            {
                SectionNumber = 1,
                Title = "INTRODUCTION",
                NavLabel = "Introduction",
                AnchorId = "pp-introduction",
                Clauses = new List<LegalClause>
                {
                    new LegalClause { Number = "", Text = "<strong>LIVELY GLOBAL TECHNOLOGIES LIMITED</strong> is committed to protecting the privacy of individuals whose personal data we collect and process. This Privacy Policy explains how we collect, use, share, and protect personal data when you use our products, services, e-commerce platform, streaming services (video, audio, or digital content), mobile applications, website and related services. It also outlines the rights you have as a data subject under the <strong>General Application and Implementation Directive (GAID 2025)</strong> and other applicable laws." },
                    new LegalClause { Number = "", Text = "By using our services, you acknowledge that you have read and understood this Privacy Policy." }
                }
            },
            new LegalSection
            {
                SectionNumber = 2,
                Title = "Scope",
                NavLabel = "Scope",
                AnchorId = "pp-scope",
                Clauses = new List<LegalClause>
                {
                    new LegalClause { Number = "", Text = "This Privacy Policy applies to all personal data processed by <strong>LIVELY GLOBAL TECHNOLOGIES LIMITED</strong> in connection with the provision of payment solutions and related services. It applies to customers, prospective customers, merchants, employees, contractors, partners, and any third party whose personal information we may lawfully collect." }
                }
            },
            new LegalSection
            {
                SectionNumber = 3,
                Title = "Legal and Regulatory Framework",
                NavLabel = "Legal and Regulatory Framework",
                AnchorId = "pp-legal-framework",
                Clauses = new List<LegalClause>
                {
                    new LegalClause { Number = "", Text = "<strong>LIVELY GLOBAL TECHNOLOGIES LIMITED</strong> processes personal data in compliance with the <strong>General Application and Implementation Directive (GAID 2025)</strong>, the CPF; Consumer Protection Framework, the CBN AML/CFT Regulations, and other relevant laws. Where applicable, <strong>LIVELY GLOBAL TECHNOLOGIES LIMITED</strong> also aligns its practices with Global best Practices." }
                }
            },
            new LegalSection
            {
                SectionNumber = 4,
                Title = "Data We Collect",
                NavLabel = "Data We Collect",
                AnchorId = "pp-data-we-collect",
                Clauses = new List<LegalClause>
                {
                    new LegalClause
                    {
                        Number = "4.1",
                        Text = "We may collect the following categories of personal data from you: Identification information such as name, date of birth, National Identification Number (NIN), Bank Verification Number (BVN), passport, or driver's license for seller identity",
                        SubClauses = new List<LegalSubClause>
                        {
                            new LegalSubClause { Label = "a.", Text = "Contact information such as phone numbers, email addresses, and residential or business addresses." },
                            new LegalSubClause { Label = "b.", Text = "Billing and delivery address." },
                            new LegalSubClause { Label = "c.", Text = "Payment details (processed via secure third-party providers)." },
                            new LegalSubClause { Label = "d.", Text = "Account login credentials which are beyond names and emails, as our parent company: LIVELY AFRICA will collect: IP addresses, unique device identifiers (like IMEI), realtime engagement patterns, purchase history, device information, and GPS location (with explicit user consent)." },
                            new LegalSubClause { Label = "e.", Text = "We will not demand for Sensitive Personal Data like biometric data in the form of facial recognition at launch." },
                            new LegalSubClause { Label = "f.", Text = "A mandatory Data Protection Impact Assessment (DPIA) will be completed and approved before any processing of Sensitive Personal Data begins." }
                        }
                    },
                    new LegalClause { Number = "", Text = "We collect account information such as name, email, and phone number, as well as valid government-issued identification documents (e.g., NIN, International Passport, or Driver's License) for users and sellers engaging in live-streaming or financial transactions to ensure a high standard of platform security." },
                    new LegalClause
                    {
                        Number = "4.2",
                        Text = "<strong>Automatically Collected Data</strong>",
                        SubClauses = new List<LegalSubClause>
                        {
                            new LegalSubClause { Label = "a.", Text = "IP address" },
                            new LegalSubClause { Label = "b.", Text = "Device type and browser information" },
                            new LegalSubClause { Label = "c.", Text = "Location data" },
                            new LegalSubClause { Label = "d.", Text = "Usage data (pages viewed, time spent, clicks)" }
                        }
                    },
                    new LegalClause
                    {
                        Number = "4.3",
                        Text = "<strong>Streaming &amp; Content Data</strong>",
                        SubClauses = new List<LegalSubClause>
                        {
                            new LegalSubClause { Label = "&bull;", Text = "Viewing history" },
                            new LegalSubClause { Label = "&bull;", Text = "Watch preferences" },
                            new LegalSubClause { Label = "&bull;", Text = "Search queries" },
                            new LegalSubClause { Label = "&bull;", Text = "Content interactions" }
                        }
                    },
                    new LegalClause { Number = "4.4", Text = "<strong>Content and Metadata (Streaming Services):</strong> We collect the content you create, upload, or stream on our platform, including videos, audio recordings, and live-streams (\"User Content\"). This includes Metadata associated with your content, which describes how, when, and where the content was created and who created it. We may also scan and analyze your User Content and messages for content moderation, safety, and to provide personalized recommendations." },
                    new LegalClause { Number = "4.5", Text = "<strong>Technical and Behavioral Information:</strong> We automatically collect information about your device and how you interact with our services, including IP address, device model, operating system, keystroke patterns or rhythms, battery state, and audio settings. We also track the duration and frequency of your use, your searches, views, and engagement with other users or products." }
                }
            },
            new LegalSection
            {
                SectionNumber = 5,
                Title = "How We Use Personal Data",
                NavLabel = "How We Use Personal Data",
                AnchorId = "pp-how-we-use",
                Clauses = new List<LegalClause>
                {
                    new LegalClause { Number = "", Text = "<strong>LIVELY GLOBAL TECHNOLOGIES LIMITED</strong> processes personal data strictly for lawful purposes, which may include:" },
                    new LegalClause { Number = "", Text = "<strong>Providing streaming services, personalizing content, and customer support:</strong> Delivering the core media experience and assisting users." },
                    new LegalClause
                    {
                        Number = "",
                        Text = "",
                        SubClauses = new List<LegalSubClause>
                        {
                            new LegalSubClause { Label = "a.", Text = "<strong>Creating and managing your account:</strong> Handling registration and user profiles." },
                            new LegalSubClause { Label = "b.", Text = "<strong>Communicating important updates or changes to our services:</strong> Sending essential service-related notifications." },
                            new LegalSubClause { Label = "c.", Text = "<strong>Processing orders and delivering products:</strong> Managing the e-commerce lifecycle from purchase to physical delivery." },
                            new LegalSubClause { Label = "d.", Text = "<strong>Preventing, detecting, and investigating fraud or illegal activities:</strong> Ensuring platform security and integrity." },
                            new LegalSubClause { Label = "e.", Text = "<strong>Meeting regulatory reporting obligations:</strong> Complying with mandatory legal requirements." },
                            new LegalSubClause { Label = "f.", Text = "<strong>Improving our services, technology, and customer experience:</strong> Using data to enhance app functionality and user satisfaction." },
                            new LegalSubClause { Label = "g.", Text = "<strong>Profiling and Recommendations:</strong> We use automated systems and algorithms to analyze your behavior and preferences to provide a personalized \"For You\" experience, including product recommendations and content feeds." },
                            new LegalSubClause { Label = "h.", Text = "<strong>Training and refining our artificial intelligence models:</strong> (Such as AI Virtual Hosts and Smart Recommendation engines) to enhance the interactive features and personalization of our streaming services." }
                        }
                    }
                }
            },
            new LegalSection
            {
                SectionNumber = 6,
                Title = "Legal Basis for Processing",
                NavLabel = "Legal Basis for Processing",
                AnchorId = "pp-legal-basis",
                Clauses = new List<LegalClause>
                {
                    new LegalClause { Number = "", Text = "In accordance with the NDPA, we process your data only when we have a legal basis to do so, including:" },
                    new LegalClause
                    {
                        Number = "",
                        Text = "",
                        SubClauses = new List<LegalSubClause>
                        {
                            new LegalSubClause { Label = "&bull;", Text = "<strong>Consent:</strong> Where you have given clear consent for specific purposes." },
                            new LegalSubClause { Label = "&bull;", Text = "<strong>Contractual Necessity:</strong> Where processing is required to perform our agreement with you." },
                            new LegalSubClause { Label = "&bull;", Text = "<strong>Legitimate Interests:</strong> For our business interests, such as fraud detection, improving our algorithms, and ensuring the security of our streaming infrastructure, provided these do not override your privacy rights." },
                            new LegalSubClause { Label = "&bull;", Text = "<strong>Legal Obligation:</strong> Where we must comply with Nigerian law (e.g., AML/KYC and other requirements)." }
                        }
                    }
                }
            },
            new LegalSection
            {
                SectionNumber = 7,
                Title = "COOKIES AND TRACKING TECHNOLOGIES",
                NavLabel = "Cookies and Tracking Technologies",
                AnchorId = "pp-cookies",
                Clauses = new List<LegalClause>
                {
                    new LegalClause { Number = "", Text = "We use cookies and similar technologies to:" },
                    new LegalClause
                    {
                        Number = "",
                        Text = "",
                        SubClauses = new List<LegalSubClause>
                        {
                            new LegalSubClause { Label = "&bull;", Text = "Enhance user experience" },
                            new LegalSubClause { Label = "&bull;", Text = "Remember preferences" },
                            new LegalSubClause { Label = "&bull;", Text = "Analyze traffic and usage patterns" }
                        }
                    },
                    new LegalClause { Number = "", Text = "You may disable cookies through your browser settings, but this may affect functionality." }
                }
            },
            new LegalSection
            {
                SectionNumber = 8,
                Title = "Profiling, and Live Stream Data Management",
                NavLabel = "Profiling, and Live Stream Data Management",
                AnchorId = "pp-profiling",
                Clauses = new List<LegalClause>
                {
                    new LegalClause { Number = "8.1", Text = "The Platform may utilize automated systems and algorithms to <strong>recommend content and rank streamers</strong> based on user preferences, engagement patterns, and other relevant metrics." },
                    new LegalClause { Number = "8.2", Text = "In compliance with the Nigeria Data Protection Act 2023, users shall be provided with <strong>a clear and accessible mechanism to opt out of automated profiling</strong>, including any processing used for personalized recommendations." },
                    new LegalClause { Number = "8.3", Text = "Where applicable, we shall ensure that such automated processing is conducted in a fair, transparent, and lawful manner, and does not adversely affect the rights and freedoms of users." }
                }
            },
            new LegalSection
            {
                SectionNumber = 9,
                Title = "Live Stream Data and Storage",
                NavLabel = "Live Stream Data and Storage",
                AnchorId = "pp-livestream-data",
                Clauses = new List<LegalClause>
                {
                    new LegalClause { Number = "9.1", Text = "The Platform may record live streaming sessions conducted on its services for purposes including, but not limited to, <strong>quality assurance, dispute resolution, compliance, and system improvement.</strong>" },
                    new LegalClause { Number = "9.2", Text = "All recorded live stream content shall be retained for a <strong>rolling period of twelve (12) months</strong> from the date of recording." },
                    new LegalClause { Number = "9.3", Text = "Upon expiration of the applicable retention period, such recordings shall be <strong>securely deleted or irreversibly anonymized/pseudonymized</strong>, in accordance with applicable data protection requirements." },
                    new LegalClause { Number = "9.4", Text = "We shall implement appropriate <strong>technical and organizational measures</strong> to ensure the security, integrity, and confidentiality of all recorded data." },
                    new LegalClause { Number = "", Text = "While we utilize global infrastructure for service delivery, in compliance with local regulatory requirements and NITDA guidelines, we maintain a synchronized copy or metadata of all critical transactional and user registration data within a certified data center located in Nigeria." }
                }
            },
            new LegalSection
            {
                SectionNumber = 10,
                Title = "Sharing of Personal Data",
                NavLabel = "Sharing of Personal Data",
                AnchorId = "pp-sharing",
                Clauses = new List<LegalClause>
                {
                    new LegalClause { Number = "", Text = "We do not sell your personal data. However, we may share personal data with:" },
                    new LegalClause
                    {
                        Number = "",
                        Text = "",
                        SubClauses = new List<LegalSubClause>
                        {
                            new LegalSubClause { Label = "1.", Text = "Service Providers and Infrastructure: We share your information with third-party service providers who perform functions on our behalf, including payment processors (e.g., for e-commerce transactions), logistics and shipping partners for physical deliveries, and Content Delivery Networks (CDNs) to ensure high-quality video and audio streaming. These partners are contractually obligated to protect your data and may not use it for their own independent purposes." },
                            new LegalSubClause { Label = "2.", Text = "Payment processors: We share data with secure payment gateways to facilitate transactions and the management of escrowed funds. Personal data is shared to ensure payments are held securely until delivery is confirmed by the buyer, in line with our transaction model." },
                            new LegalSubClause { Label = "3.", Text = "Regulators such as the Central Bank of Nigeria, the Nigeria Financial Intelligence Unit (NFIU), and the Economic and Financial Crimes Commission (EFCC), and others when required by law." },
                            new LegalSubClause { Label = "4.", Text = "Third-party service providers (such as IT, cloud hosting, or payment partners, Payment Gateway partners, integrated Logistics partners, and SMS gateways. who process data on our behalf under strict contractual agreements." },
                            new LegalSubClause { Label = "5.", Text = "Communication Partners: This includes SMS gateways and email service providers used to transmit One-Time Passwords (OTPs), order updates, and security notifications to your registered phone number or email address." },
                            new LegalSubClause { Label = "6.", Text = "Law enforcement or government agencies, if required to comply with legal obligations." },
                            new LegalSubClause { Label = "7.", Text = "Logistics and delivery partners." },
                            new LegalSubClause { Label = "8.", Text = "Streaming infrastructure providers." }
                        }
                    }
                }
            },
            new LegalSection
            {
                SectionNumber = 11,
                Title = "Children's Privacy",
                NavLabel = "Children's Privacy",
                AnchorId = "pp-childrens-privacy",
                Clauses = new List<LegalClause>
                {
                    new LegalClause { Number = "", Text = "Our streaming and e-commerce services are not intended for children under the age of 13 (or the legal age of consent in Nigeria). We do not knowingly collect personal data from children. If we become aware that a child has provided us with personal data without parental consent, we will take steps to delete such information and terminate the associated account immediately. We may use age-verification tools to ensure compliance with this section." }
                }
            },
            new LegalSection
            {
                SectionNumber = 12,
                Title = "Access Control",
                NavLabel = "Access Control",
                AnchorId = "pp-access-control",
                Clauses = new List<LegalClause>
                {
                    new LegalClause { Number = "", Text = "Access to raw video data shall be strictly restricted to the Data Protection Officer (DPO) and duly authorized security personnel on a need-to-know basis. All video data shall be securely encrypted at rest in accordance with recognized industry standards and best practices." }
                }
            },
            new LegalSection
            {
                SectionNumber = 13,
                Title = "Data Retention",
                NavLabel = "Data Retention",
                AnchorId = "pp-data-retention",
                Clauses = new List<LegalClause>
                {
                    new LegalClause { Number = "13.1", Text = "We retain personal data only for as long as is necessary to fulfill the purposes for which it was collected, or as required under applicable laws and regulations. For instance, personal data obtained for Know Your Customer (KYC) and Anti-Money Laundering (AML) purposes shall be retained for a minimum period of five (5) years, in compliance with statutory obligations. Upon expiration of the applicable retention period, such data shall be securely deleted, anonymized, or otherwise rendered irreversibly unusable." },
                    new LegalClause { Number = "13.2", Text = "Live streams are recorded and maintained for a rolling retention period of twelve (12) months for purposes including quality assurance, dispute resolution, and the training and improvement of artificial intelligence systems. At the end of this period, such recordings shall be securely deleted or pseudonymized in accordance with applicable data protection standards." }
                }
            },
            new LegalSection
            {
                SectionNumber = 14,
                Title = "Data Security",
                NavLabel = "Data Security",
                AnchorId = "pp-data-security",
                Clauses = new List<LegalClause>
                {
                    new LegalClause { Number = "", Text = "We use appropriate technical and organizational measures to protect personal data against unauthorized access, alteration, disclosure, or destruction. These measures include encryption, firewalls, multi-factor authentication, continuous monitoring, and strict access controls. Despite these safeguards, no system can be completely secure, and we encourage users to also take steps to protect their personal information notwithstanding we pledged to maintain a synchronized, locally hosted copy or metadata of all critical transactional and user registration data within a certified Nigerian data center." },
                    new LegalClause { Number = "14.1", Text = "<strong>Right to Portability and Specific Deletion:</strong> You have the right to request a copy of your personal data in a structured, commonly used, and machine-readable format and to have that data transmitted to another controller." },
                    new LegalClause { Number = "14.2", Text = "<strong>Account Closure:</strong> To permanently delete your data and discontinue your relationship with us, you may use the \"Close Account\" feature within the App settings or email our DPO at_______________. Please note that we may retain certain information as required by law (e.g., financial records for tax purposes or audit trails)." }
                }
            },
            new LegalSection
            {
                SectionNumber = 15,
                Title = "Your Rights",
                NavLabel = "Your Rights",
                AnchorId = "pp-your-rights",
                Clauses = new List<LegalClause>
                {
                    new LegalClause { Number = "", Text = "As a data subject, you have the following rights under the <strong>Nigerian Data Protection Act (2023) and the General Application and Implementation Directive (GAID 2025):</strong>" },
                    new LegalClause
                    {
                        Number = "",
                        Text = "",
                        SubClauses = new List<LegalSubClause>
                        {
                            new LegalSubClause { Label = "A.", Text = "The right to request access to your personal data" },
                            new LegalSubClause { Label = "B.", Text = "The right to request correction of inaccurate or incomplete data." },
                            new LegalSubClause { Label = "C.", Text = "The right to request deletion of your data, where permitted by law." },
                            new LegalSubClause { Label = "D.", Text = "The right to restrict or object to certain forms of processing." },
                            new LegalSubClause { Label = "E.", Text = "The right to data portability" },
                            new LegalSubClause { Label = "F.", Text = "The right to withdraw consent at any time where processing is based on consent." },
                            new LegalSubClause { Label = "G.", Text = "The right to have personal data obliterated or suppressed from the internet where total erasure can not be achieved." }
                        }
                    },
                    new LegalClause { Number = "", Text = "The right to lodge a complaint with the commission." },
                    new LegalClause { Number = "", Text = "Requests should be directed to our Data Protection Officer (DPO), and we will respond within the statutory timelines." }
                }
            },
            new LegalSection
            {
                SectionNumber = 16,
                Title = "Data Breaches",
                NavLabel = "Data Breaches",
                AnchorId = "pp-data-breaches",
                Clauses = new List<LegalClause>
                {
                    new LegalClause { Number = "", Text = "In the unlikely event of a data breach that poses a significant risk to your rights or freedoms, <strong>LIVELY GLOBAL TECHNOLOGIES LIMITED</strong> will notify you and the relevant regulator (such as NDPC) within 72 hours of becoming aware of the breach." }
                }
            },
            new LegalSection
            {
                SectionNumber = 17,
                Title = "Changes to This Privacy Policy",
                NavLabel = "Changes to This Privacy Policy",
                AnchorId = "pp-changes",
                Clauses = new List<LegalClause>
                {
                    new LegalClause { Number = "", Text = "We may update this Privacy Policy from time to time to reflect legal, regulatory, or operational changes. Updated versions will be published on our website and mobile applications." }
                }
            },
            new LegalSection
            {
                SectionNumber = 18,
                Title = "Contact Us",
                NavLabel = "Contact Us",
                AnchorId = "pp-contact",
                Clauses = new List<LegalClause>
                {
                    new LegalClause { Number = "", Text = "If you have questions, concerns, or requests regarding your personal data, please contact us @___________________ or reach out to our Data Protection Officer (DPO) on this line _______________." },
                    new LegalClause { Number = "", Text = "<strong>LIVELY GLOBAL TECHNOLOGIES LIMITED</strong>" }
                }
            },
            new LegalSection
            {
                SectionNumber = 19,
                Title = "Interpretation of Acronyms",
                NavLabel = "Interpretation of Acronyms",
                AnchorId = "pp-acronyms",
                Clauses = new List<LegalClause>
                {
                    new LegalClause
                    {
                        Number = "",
                        Text = "",
                        SubClauses = new List<LegalSubClause>
                        {
                            new LegalSubClause { Label = "A.", Text = "AML &ndash; Anti-Money Laundering" },
                            new LegalSubClause { Label = "B.", Text = "BVN &ndash; Bank Verification Number" },
                            new LegalSubClause { Label = "C.", Text = "CBN &ndash; Central Bank of Nigeria" },
                            new LegalSubClause { Label = "D.", Text = "DPO &ndash; Data Protection Officer" },
                            new LegalSubClause { Label = "E.", Text = "EFCC &ndash; Economic and Financial Crimes Commission" },
                            new LegalSubClause { Label = "F.", Text = "IP &ndash; Internet Protocol &nbsp; F. KYC &ndash; Know Your Customer" },
                            new LegalSubClause { Label = "G.", Text = "GAID &ndash; General Application and Implementation Directive" },
                            new LegalSubClause { Label = "H.", Text = "NFIU &ndash; Nigeria Financial Intelligence Unit" },
                            new LegalSubClause { Label = "I.", Text = "NIN &ndash; National Identification Number" },
                            new LegalSubClause { Label = "J.", Text = "NDPC &ndash; Nigerian Data Protection Commission" },
                            new LegalSubClause { Label = "K.", Text = "TLS &ndash; Transport Layer Security" },
                            new LegalSubClause { Label = "L.", Text = "NDPC &ndash; The Nigeria Data Protection Commission" }
                        }
                    }
                }
            }
        }
            };
        }
    }
}