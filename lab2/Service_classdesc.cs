class ServiceCenter {
	public string address;
	public Review[] reviews;
	
	public string getInfo() {
	}
}

abstract class Client {
	public string name;
	private string phoneNum;
	private string address;
	public Review[] reviews;
	public Device[] devices;
	
	abstract public void payBill(Claim c);
	abstract public void writeReview(ServiceCenter serv, Claim c, string reviewText);
}

class Individual : Client {
	public override void payBill(Claim c) {
	}
	public override void writeReview(ServiceCenter serv, Claim c, string reviewText) {
	}
}

class CorporateEntity : Client {
	public string company;
	
	public override void payBill(Claim c) {
	}
	public override void writeReview(ServiceCenter serv, Claim c, string reviewText) {
	}
}

class Device {
	public string model;
	public string manufacturer;
	private Client owner;
	public Issue[] issues;
	
	public Issue[] examine() {
		if (issues == null) {
			int i = 0;
		}
		else {
			foreach Issue issue in issues) {
				issue.claim.updateClaim();
			}
			int i = issues.length;
		}
		while(true) {
			string issueText = Console.ReadLine();
			if (issueText = '0') break;
			issues[i] = new Issue(this, issueText);
			Claim claim = new Claim(issues[i]);
			i++;
		}
		return issues;
	}
}

class Issue {
	public string description;
	public string status;
	public Device device;
	public Claim claim;
}

class Claim {
	public float bill;
	public string claimStatus;
	public string dateTime;
	public bool isPaid;
	public Issue issue;
	
	public void updateClaim() {
	}
}

class Review {
	public float rating;
	public string reviewText;
	public ServiceCenter center;
	public Client author;
	public Claim claim;
}