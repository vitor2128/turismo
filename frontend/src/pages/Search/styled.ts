import styled from "styled-components";

export const Container = styled.div`
	max-width: 1024px;
	margin: auto;
	padding: 20px;
`;

export const Header = styled.div`
	display: flex;
  justify-content: space-between;
  align-items: center;
  margin-bottom: 20px;
	> h1 {
		text-transform: uppercase;
		color: #888;
		
	}

	> a {
		text-decoration: none;
		border: 1px solid #ccc;
		border-radius: 8px;
		padding: 0 20px;
	}
`;

export const InputContainer = styled.div `
  > input {
		display: flex;
		height: 42px;
		border: 1px solid #ccc;
		border-radius: 8px;
		width: 100%;
		margin-bottom: 20px;
		padding: 0 10px;
		font-size: 16px;
	}
`;