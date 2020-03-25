# Leads Manager
A microservice used in the retrieval of leads (in this example, higher education student prospects) data from multiple sources, such as a CMS along with internal legacy databases, and converting that data to a specific XML schema for use with Talisma.
Dot Net Core was used to rebuild the revious version of the app into this iteration, both for fun as well as seeing how well a Dot Net Core application would work in a production environment.

The models are currently inconsistent in design, and these may change but I also like having the annotations in there to demonstrate how to map the names within MVC.

The primary function of this app was, originally, to serve as an API for third-party vendors to deliver leads packages directly to the client's DB, but things evolved to the point where API functions were no longer necessary, and the app served as a getter for the leads info from multiple internal sources. Upon retrieval, each lead could be converted to XML, which was required in a specific XML schema (see ToXml.cs) so that the submission to Talisma
(talisma.com) would not be rejected. Other features have not been added to the app, such as automated Talisma submissions and bulk manual submissions.
