<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core"%>
<!-- for forms -->
<%@ taglib prefix="form" uri="http://www.springframework.org/tags/form" %>
<%@ taglib prefix = "fmt" uri = "http://java.sun.com/jsp/jstl/fmt" %>
<!-- for validation -->
<%@ page isErrorPage="true" %>
<!DOCTYPE html>
<html>
<head>
<!-- for Bootstrap CSS -->
<link rel="stylesheet" href="/webjars/bootstrap/css/bootstrap.min.css" />
<!-- YOUR own local CSS -->
<link rel="stylesheet" type="text/css" href="/css/style.css">
<!-- For any Bootstrap that uses JS -->
<script src="/webjars/bootstrap/js/bootstrap.min.js"></script>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
	<div class="container">
		<h1 class="display-3">Edit a Burger:</h1>
		<form:form action="/burgers/update/${burger.getId()}" method="post" modelAttribute="burger" class="col-6">
			<input type="hidden" name="_method" value="put">
			<div class="mt-3">
				<form:label path="burgerName" class="form-label">Burger Name</form:label>
				<form:input path="burgerName" class="form-control"/>
				<form:errors path="burgerName" class="text-danger"/>
			</div>
			<div class="mt-3">
				<form:label path="restaurantName" class="form-label">Restaurant Name</form:label>
				<form:input path="restaurantName" class="form-control"/>
				<form:errors path="restaurantName" class="text-danger"/>
			</div>
			<div class="mt-3">
				<form:label path="rating" class="form-label">Rating</form:label>
				<form:input type="number" path="rating" class="form-control"/>
				<form:errors path="rating" class="text-danger"/>
			</div>
			<div class="mt-3">
				<form:label path="notes" class="form-label">Notes</form:label>
				<form:textarea path="notes" class="form-control"></form:textarea>
				<form:errors path="notes" class="text-danger"/>
			</div>
			<button class="btn btn-primary btn-lg mt-5 float-end">Update</button>
		</form:form>
	</div>
</body>
</html>