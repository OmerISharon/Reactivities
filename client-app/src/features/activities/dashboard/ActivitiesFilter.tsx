import Calendar from 'react-calendar';
import { Header, Menu } from 'semantic-ui-react';

export default function ActivitiesFilters() {
    return (
        <>
        <Menu verical='true' size='large' style={{width: '100%', marginTop: 28}}>
            <Header attached color='teal'>
                <Menu.Item content='All Activities' />
                <Menu.Item content="I'm going" />
                <Menu.Item content="I'm hosting" />
            </Header>
        </Menu>
        <Header /> 
        <Calendar />
        </>
    )
}