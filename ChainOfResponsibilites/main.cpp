#include <iostream>
#include <string>
#include <vector>

class Request {
public:
	Request(std::string body);
	std::string getBody();
private:
	std::string body;
};


class Middleware {
public:
	explicit Middleware(Request* request);
	virtual bool handle() = 0;
protected:
	Request* request;
};

class RequestPipeline {
public:
	bool preprocess(Request* request);
    void addMiddleware(Middleware* middleware);
private:
	std::vector<Middleware*> middlewares;
};

class Validate : public Middleware {
public:
	Validate(Request* request) : Middleware(request) {}
	bool handle();
};

class Authenticate : public Middleware {
public:
	Authenticate(Request* request) : Middleware(request) {
        
    }
	bool handle();
};

Request::Request(std::string body) {
    this->body = body;
}

std::string Request::getBody() {
    return this->body;
}

Middleware::Middleware(Request* request) {
    this->request = request;
}

void RequestPipeline::addMiddleware(Middleware* middleware) {
    this->middlewares.push_back(middleware);
}

bool RequestPipeline::preprocess(Request* request) {
    for (auto item: this->middlewares) {
        if (!item->handle()) {
            std::cout << "Pipeline broken" << std::endl;
            break;
            return false;
        }
    }

    std::cout << "Pipeline finished" << std::endl;
    return true;
}

bool Validate::handle() {
    if (this->request->getBody().find("valid") != std::string::npos) {
        return true;
    }
    else {
        std::cout << "Validating went wrong" << std::endl;
        return false;
    }
}

bool Authenticate::handle() {
    if (this->request->getBody().find("password:123") != std::string::npos) {
        return true;
    }
    else {
        std::cout << "Authentication went wrong" << std::endl;
        return false;
    }
}

int main() {
    Request* request = new Request("valid password:123 body auuuuuuuu2137");

    Validate* validate = new Validate(request);
    Authenticate* authenticate = new Authenticate(request);

    RequestPipeline* pipeline = new RequestPipeline();
    pipeline->addMiddleware(validate);
    pipeline->addMiddleware(authenticate);

    pipeline->preprocess(request);
}