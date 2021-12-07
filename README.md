# STIMA-PESALINK
This is Web api Core 3.1 for performing transaction between banks

Integrated Payment Services Limited (IPSL) is in the process of upgrading PESALINK platform from the
current switch running on ISO8583 standard to a new Instant Payment Switch (IPS) running on
ISO20022.

The major reason that informed IPSL to upgrade is that the existing SWITCH runs on ISO8583 as the financial industry is moving away from ISO8583 to ISO20022 message standard.

Below are the functionalities that will be provided by the new IPS:

Account validation – This will be done against receiver bank’s data via API.

Support of different types of payments (Credit Transfers and Request to Pay, Request to Pay by PSP and Request to Pay with Mandate ID);

Support the three-layer structure of participants (direct, indirect and payment initiators or sub participants);

Limit management system for payment transaction processing;
Fee management system;
Reports 

Anti-Fraud checks
The IPS is designed to provide secure payment and information exchange via secure network.
Access to IPS services is provided for eligible Participants through Unified REST API

Dummy xml of what is required
![sample xml](https://github.com/justus57/STIMA-PESALINK/blob/master/images/sample%20xml.png?raw=true)

this is inteface
![api](https://github.com/justus57/STIMA-PESALINK/blob/master/images/api.png?raw=true)
