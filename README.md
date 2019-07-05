# PhoneDirectory
API for Phone number directory with customer details

Phone Directory API is able to :
•	Get all phone numbers
GET
URL : http://localhost:50236/api/Phone/All

•	Get all phone numbers of a single customer
GET
http://localhost:50236/api/Phone/GetByCustomerId?customerID=1111

•	Add a new phone number to a customer’s account
POST
URL : http://localhost:50236/api/Phone/AddPhoneNumber

Api Request : 
{
	"customerId":"6666",
	"customerName": "BBBB",
	"customerPhoneNumber": "0412543680",
	"active": true
}

Api Response: string
"success" OR "failed"

•	Activate a phone number. 
POST
URL : http://localhost:50236/api/Phone/ActivatePhNo

Api Request: 
{
	"phoneId": 2,
	"active": false
}

Api Response: string
"success" OR "failed"




NOT IMPLEMENTED:
UNIT TESTS(using Nsubstitute),
LOGGING(nlogger/log4net),
BETTER EXCEPTION HANDLING
